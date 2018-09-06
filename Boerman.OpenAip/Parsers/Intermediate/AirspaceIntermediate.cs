using System.Collections.Generic;
using System.Xml.Serialization;

namespace Boerman.OpenAip.Parsers.Intermediate
{
    public static class AirspaceIntermediate
    {
        [XmlRoot(ElementName = "ALT")]
        public class ALT
        {
            [XmlAttribute(AttributeName = "UNIT")]
            public string Unit { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "ALTLIMIT_TOP")]
        public class AltitudeLimitTop
        {
            [XmlElement(ElementName = "ALT")]
            public ALT Altitude { get; set; }
            [XmlAttribute(AttributeName = "REFERENCE")]
            public string Reference { get; set; }
        }

        [XmlRoot(ElementName = "ALTLIMIT_BOTTOM")]
        public class AltitudeLimitBottom
        {
            [XmlElement(ElementName = "ALT")]
            public ALT Altitude { get; set; }
            [XmlAttribute(AttributeName = "REFERENCE")]
            public string Reference { get; set; }
        }

        [XmlRoot(ElementName = "GEOMETRY")]
        public class Geometry
        {
            [XmlElement(ElementName = "POLYGON")]
            public string Polygon { get; set; }
        }

        [XmlRoot(ElementName = "ASP")]
        public class Airspace
        {
            [XmlElement(ElementName = "VERSION")]
            public string Version { get; set; }
            [XmlElement(ElementName = "ID")]
            public string Id { get; set; }
            [XmlElement(ElementName = "COUNTRY")]
            public string Country { get; set; }
            [XmlElement(ElementName = "NAME")]
            public string Name { get; set; }
            [XmlElement(ElementName = "ALTLIMIT_TOP")]
            public AltitudeLimitTop AltitudeLimitTop { get; set; }
            [XmlElement(ElementName = "ALTLIMIT_BOTTOM")]
            public AltitudeLimitBottom AltitudeLimitBottom { get; set; }
            [XmlElement(ElementName = "GEOMETRY")]
            public Geometry Geometry { get; set; }
            [XmlAttribute(AttributeName = "CATEGORY")]
            public string Category { get; set; }
        }

        [XmlRoot(ElementName = "AIRSPACES")]
        public class Airspaces
        {
            [XmlElement(ElementName = "ASP")]
            public List<Airspace> Airspace { get; set; }
        }

        [XmlRoot(ElementName = "OPENAIP")]
        public class OpenAip
        {
            [XmlElement(ElementName = "AIRSPACES")]
            public Airspaces Airspaces { get; set; }
            [XmlAttribute(AttributeName = "VERSION")]
            public string Version { get; set; }
            [XmlAttribute(AttributeName = "DATAFORMAT")]
            public string DataFormat { get; set; }
        }
    }
}
