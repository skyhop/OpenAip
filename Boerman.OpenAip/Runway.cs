namespace Boerman.OpenAip
{
    public class Runway
    {
        public string Name { get; set; }

        public SurfaceType Surface { get; set; }

        public decimal Length { get; set; }

        public decimal Width { get; set; }

        public string Operations { get; set; }

        public (StrengthType Type, string Value)? Strength { get; set; }

        public RunwayDirection[] Directions;
    }
}
