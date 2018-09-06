using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;

namespace Boerman.OpenAip.Parsers
{
    public static class Airspace
    {
        public static IEnumerable<Boerman.OpenAip.Airspace> Parse(string contents)
        {
            var reader = new StringReader(contents);
            return Parse(reader);
        }

        public static IEnumerable<Boerman.OpenAip.Airspace> Parse(TextReader contents)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Intermediate.AirspaceIntermediate.OpenAip));

            var intermediate = serializer.Deserialize(contents) as Intermediate.AirspaceIntermediate.OpenAip;

            var result = intermediate?.Airspaces.Airspace.Select(q => new Boerman.OpenAip.Airspace
            {
                Category = (AirspaceCategory)Enum.Parse(typeof(AirspaceCategory), q.Category, true),
                Id = Convert.ToInt32(q.Id),
                Country = q.Country,
                LowerLimit = new Altitude
                {
                    Reference = Extensions.GetReferencePane(q.AltitudeLimitBottom.Reference),
                    Unit = Extensions.GetAltitudeUnit(q.AltitudeLimitBottom.Altitude.Unit),
                    Value = Convert.ToInt32(q.AltitudeLimitBottom.Altitude.Text)
                },
                Name = q.Name,
                UpperLimit = new Altitude
                {
                    Reference = Extensions.GetReferencePane(q.AltitudeLimitTop.Reference),
                    Unit = Extensions.GetAltitudeUnit(q.AltitudeLimitTop.Altitude.Unit),
                    Value = Convert.ToInt32(q.AltitudeLimitTop.Altitude.Text)
                },
                Polygon = new Polygon(new LinearRing(
                    q.Geometry.Polygon
                        .Split(',')
                        .Select(w => w.Trim().Split(' ')
                            .Select(e => Convert.ToDouble(e.Trim()))
                            .ToArray())
                        .Select(w => new Coordinate(w[0], w[1])).ToArray()))
            }).ToArray();

            return result;
        }
    }
}
