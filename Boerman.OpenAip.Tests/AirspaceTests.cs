using System;
using System.Linq;
using GeoAPI.Geometries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetTopologySuite.Geometries;

namespace Boerman.OpenAip.Tests
{
    [TestClass]
    public class AirspaceTests
    {
        [TestMethod]
        public void SpecExampleParseTest()
        {
            var r = Parsers.Airspace.Parse(@"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<OPENAIP VERSION=""367810a0f94887bf79cd9432d2a01142b0426795"" DATAFORMAT=""1.1"">
<AIRSPACES>
<ASP CATEGORY=""WAVE"">
  <VERSION>367810a0f94887bf79cd9432d2a01142b0426795</VERSION>
  <ID>18024</ID>
  <COUNTRY>DE</COUNTRY>
  <NAME>ALB-OST</NAME>
  <ALTLIMIT_TOP REFERENCE=""STD"">
    <ALT UNIT=""FL"">100</ALT>
  </ALTLIMIT_TOP>
  <ALTLIMIT_BOTTOM REFERENCE=""STD"">
    <ALT UNIT=""FL"">75</ALT>
  </ALTLIMIT_BOTTOM>
  <GEOMETRY>
    <POLYGON>9.6255555555556 48.5625, 9.8477777777778 48.659444444444, 9.8488590649036 48.671520456103, 9.8491357659723 48.676179034769, 9.8494899239756 48.688273884048, 9.8494860905378 48.692936043918, 9.8477777777778 48.705, 9.9372222222222 48.714166666667, 9.9380313248976 48.696291564689, 9.937831067577 48.678408978203, 9.9366228021006 48.660543713921, 9.9344092727478 48.64272052819, 9.9319444444444 48.630833333333, 9.6391666666667 48.496388888889, 9.6255555555556 48.5625</POLYGON>
  </GEOMETRY>
</ASP>
</AIRSPACES>
</OPENAIP>").FirstOrDefault();

            Assert.AreEqual(AirspaceCategory.Wave, r.Category);
            Assert.AreEqual(100, r.UpperLimit.Value);
            Assert.AreEqual(ReferencePane.StandardAtmosphere, r.UpperLimit.Reference);
            Assert.AreEqual(AltitudeUnit.FlightLevel, r.UpperLimit.Unit);
            Assert.AreEqual(75, r.LowerLimit.Value);
            Assert.AreEqual(ReferencePane.StandardAtmosphere, r.LowerLimit.Reference);
            Assert.AreEqual(AltitudeUnit.FlightLevel, r.LowerLimit.Unit);
            Assert.AreEqual("DE", r.Country);
            Assert.AreEqual(new Polygon(new LinearRing(
                "9.6255555555556 48.5625, 9.8477777777778 48.659444444444, 9.8488590649036 48.671520456103, 9.8491357659723 48.676179034769, 9.8494899239756 48.688273884048, 9.8494860905378 48.692936043918, 9.8477777777778 48.705, 9.9372222222222 48.714166666667, 9.9380313248976 48.696291564689, 9.937831067577 48.678408978203, 9.9366228021006 48.660543713921, 9.9344092727478 48.64272052819, 9.9319444444444 48.630833333333, 9.6391666666667 48.496388888889, 9.6255555555556 48.5625"
                    .Split(',')
                    .Select(w => w.Trim().Split(' ')
                        .Select(Convert.ToDouble)
                        .ToArray())
                    .Select(w => new Coordinate(w[0], w[1])).ToArray())).ToString(), r.Polygon.ToString());
        }
    }
}
