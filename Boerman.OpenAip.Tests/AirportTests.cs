using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Boerman.OpenAip.Tests
{
    [TestClass]
    public class AirportTests
    {
        [TestMethod]
        public void SpecExampleParseTest()
        {
            var r = Parsers.Airport.Parse(@"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<OPENAIP VERSION=""369694"" DATAFORMAT=""1.1"">
<WAYPOINTS>
<AIRPORT TYPE=""AF_CIVIL"">
  <COUNTRY>DE</COUNTRY>
  <NAME>HAHNWEIDE</NAME>
  <ICAO>EDST</ICAO>
  <GEOLOCATION>
    <LAT>48.6317</LAT>
    <LON>9.4294</LON>
    <ELEV UNIT=""M"">355.7016</ELEV>
  </GEOLOCATION>
  <RADIO CATEGORY=""COMMUNICATION"">
    <FREQUENCY>128.950</FREQUENCY>
    <TYPE>OTHER</TYPE>
    <TYPESPEC>MySpecialType</TYPESPEC>
    <DESCRIPTION>This is a frequency description</DESCRIPTION>
  </RADIO>
  <RADIO CATEGORY=""NAVIGATION"">
    <FREQUENCY>111.11</FREQUENCY>
    <TYPE>ILS</TYPE>
  </RADIO>
  <RWY OPERATIONS=""ACTIVE"">
    <NAME>18L / 36R</NAME>
    <SFC>ASPH</SFC>
    <LENGTH UNIT=""M"">500</LENGTH>
    <WIDTH UNIT=""M"">50</WIDTH>
    <STRENGTH UNIT=""PCN"">PCN 65/F/A/W/T</STRENGTH>
    <DIRECTION TC=""176"">
      <RUNS>
        <TORA UNIT=""M"">520</TORA>
        <LDA UNIT=""M"">450</LDA>
      </RUNS>
      <LANDINGAIDS>
        <ILS>111.11</ILS>
        <PAPI>TRUE</PAPI>
      </LANDINGAIDS>
    </DIRECTION>
    <DIRECTION TC=""357"">
      <RUNS>
        <TORA UNIT=""M"">520</TORA>
        <LDA UNIT=""M"">450</LDA>
      </RUNS>
      <LANDINGAIDS>
        <ILS>111.11</ILS>
        <PAPI>FALSE</PAPI>
      </LANDINGAIDS>
    </DIRECTION>
  </RWY>
  <RWY OPERATIONS=""ACTIVE"">    
    <NAME>27</NAME>
    <SFC>GRAS</SFC>
    <LENGTH UNIT=""M"">555</LENGTH>
    <WIDTH UNIT=""M"">30</WIDTH>
    <DIRECTION TC=""275"">
      <RUNS>
        <TORA UNIT=""M"">400</TORA>
        <LDA UNIT=""M"">550</LDA>
      </RUNS>
    </DIRECTION>
  </RWY>
</AIRPORT>
</WAYPOINTS>
</OPENAIP>").FirstOrDefault();

            Assert.AreEqual(AirportType.AF_CIVIL, r.Type);
            Assert.AreEqual((decimal)111.11, r.Radios[1].Frequency);
            Assert.AreEqual(550, r.Runways[1].Directions[0].LDA);
        }
    }
}
