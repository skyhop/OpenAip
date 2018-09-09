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

        public static IEnumerable<Boerman.OpenAip.Airport> Parse(TextReader contents)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Intermediate.AirportIntermediate.OPENAIP));

            var intermediate = serializer.Deserialize(contents) as Intermediate.AirportIntermediate.OPENAIP;
            

            return default(IEnumerable<Boerman.OpenAip.Airport>);
        }
    }
}
