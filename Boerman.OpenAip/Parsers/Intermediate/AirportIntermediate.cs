using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Boerman.OpenAip.Parsers.Intermediate
{
    public class AirportIntermediate
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        [XmlRoot(Namespace = "", IsNullable = false)]
        public class OPENAIP
        {
            [XmlElement("WAYPOINTS")]
            public WAYPOINTS Waypoints { get; set; }

            [XmlAttribute("VERSION")]
            public uint Version { get; set; }

            [XmlAttribute("DATAFORMAT")]
            public decimal DataFormat { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class WAYPOINTS
        {
            [XmlElement("AIRPORT")]
            public AIRPORT Airport { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class AIRPORT
        {
            [XmlElement("COUNTRY")]
            public string Country { get; set; }
            [XmlElement("NAME")]
            public string Name { get; set; }
            [XmlElement("ICAO")]
            public string ICAO { get; set; }
            [XmlElement("GEOLOCATION")]
            public GEOLOCATION Geolocation { get; set; }
            [XmlElement("RADIO")]
            public RADIO[] Radio { get; set; }
            [XmlElement("RWY")]
            public RUNWAY[] Runways { get; set; }
            [XmlAttribute("TYPE")]
            public string Type { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class GEOLOCATION
        {
            [XmlElement("LAT")]
            public decimal Langitude { get; set; }
            [XmlElement("LON")]
            public decimal Longitude { get; set; }
            [XmlElement("ELEV")]
            public UNITVALUE Elevation { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class UNITVALUE
        {
            [XmlAttribute("UNIT")]
            public string Unit { get; set; }
            [XmlText]
            public string Value { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class RADIO
        {
            [XmlElement("FREQUENCY")]
            public decimal Frequency { get; set; }
            [XmlElement("TYPE")]
            public string Type { get; set; }
            [XmlElement("TYPESPEC")]
            public string TypeSpecification { get; set; }
            [XmlElement("DESCRIPTION")]
            public string Description { get; set; }
            [XmlAttribute("CATEGORY")]
            public string Category { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class RUNWAY
        {
            [XmlElement("NAME")]    
            public string Name { get; set; }
            [XmlElement("SFC")]
            public string Sfc { get; set; }
            [XmlElement("LENGTH")]
            public UNITVALUE Length { get; set; }
            [XmlElement("WIDTH")]
            public UNITVALUE Width { get; set; }
            [XmlElement("STRENGTH")]
            public UNITVALUE Strength { get; set; }
            [XmlElement("DIRECTION")]
            public DIRECTION[] Direction { get; set; }
            [XmlAttribute("OPERATIONS")]
            public string Operations { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class DIRECTION
        {
            [XmlElement("RUNS")]
            public RUNS Runs { get; set; }
            [XmlElement("LANDINGAIDS")]
            public LANDINGAIDS LandingAids { get; set; }
            [XmlAttribute("TC")]
            public ushort TC { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class RUNS
        {

            [XmlElement("TORA")]
            public UNITVALUE TORA { get; set; }
            [XmlElement("LDA")]
            public UNITVALUE LDA { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class LANDINGAIDS
        {
            [XmlElement("ILS")]
            public decimal ILS { get; set; }
            [XmlElement("PAPI")]
            public string PAPI { get; set; }
        }
    }
}
