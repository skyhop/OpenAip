using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;

namespace Boerman.OpenAip.Parsers
{
    public static class Airport
    {
        public static IEnumerable<Boerman.OpenAip.Airport> Parse(string contents)
        {
            var reader = new StringReader(contents);
            return Parse(reader);
        }

        public static List<Boerman.OpenAip.Airport> Parse(TextReader contents)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Intermediate.AirportIntermediate.OPENAIP));

            var intermediate = serializer.Deserialize(contents) as Intermediate.AirportIntermediate.OPENAIP;

            var list = intermediate?.Waypoints.Airport.Select(x => new Boerman.OpenAip.Airport
            {
                Country = x.Country,
                ICAO = x.ICAO,
                Location = new Point(
                    Convert.ToDouble(x.Geolocation.Longitude), 
                    Convert.ToDouble(x.Geolocation.Langitude), 
                    Convert.ToDouble(x.Geolocation.Elevation.Value)),
                Name = x.Name,
                Type = ConversionExtensions.Parse(x.Type, AirportType.AD_CLOSED),
                Radios = x.Radio?.Select(r => new Radio
                {
                    Category = ConversionExtensions.Parse(r.Category, RadioCategory.OHER),
                    Type = ConversionExtensions.Parse(r.Type, RadioType.OTHER),
                    Description = r.Description,
                    Frequency = r.Frequency,
                    TypeSpecification = r.TypeSpecification
                }).ToArray(),
                Runways = x.Runways?.Select(rw => new Runway
                {
                    Name = rw.Name,
                    Surface = ConversionExtensions.Parse(rw.Surface, SurfaceType.UNKN),
                    Length = Convert.ToDecimal(rw.Length.Value),
                    Width = Convert.ToDecimal(rw.Width.Value),
                    Strength = rw.Strength != null ? (ConversionExtensions.Parse(rw.Strength.Unit, StrengthType.PCN), rw.Strength.Value) : ((StrengthType, string Value)?) null,
                    Operations = rw.Operations,
                    Directions = rw.Direction.Select(rwd => new RunwayDirection
                    {
                        LDA = ConversionExtensions.ToNullableDecimal(rwd.Runs.LDA?.Value) ?? -1,
                        ILS = rwd.LandingAids?.ILS ?? -1,
                        PAPI = ConversionExtensions.ToNullableBoolean(rwd.LandingAids?.PAPI) ?? false,
                        TC = Convert.ToInt32(rwd.TC),
                        TORA = ConversionExtensions.ToNullableDecimal(rwd.Runs?.TORA.Value) ?? -1
                    }).ToArray()
                }).ToArray()
            });

            return list?.ToList();
        }
    }
}
