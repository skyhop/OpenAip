namespace Boerman.OpenAip
{
    public enum AltitudeUnit
    {
        None,
        Feet,
        FlightLevel
    }

    public static partial class Extensions
    {
        public static AltitudeUnit GetAltitudeUnit(string str)
        {
            switch (str)
            {
                case "F":
                    return AltitudeUnit.Feet;
                case "FL":
                    return AltitudeUnit.FlightLevel;
                default:
                    return AltitudeUnit.None;
            }
        }
    }
}
