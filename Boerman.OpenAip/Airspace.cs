using NetTopologySuite.Geometries;

namespace Boerman.OpenAip
{
    public class Airspace
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public AirspaceCategory Category { get; set; }
        
        public Altitude UpperLimit { get; set; }
        public Altitude LowerLimit { get; set; }
        public Polygon Polygon { get; set; }
    }
}
