namespace Boerman.OpenAip
{
    public enum ReferencePane
    {
        None,
        Ground,
        MainSeaLevel,
        StandardAtmosphere
    }

    public static partial class Extensions
    {
        public static ReferencePane GetReferencePane(string str)
        {
            switch (str)
            {
                case "GND":
                    return ReferencePane.Ground;
                case "MSL":
                    return ReferencePane.MainSeaLevel;
                case "STD":
                    return ReferencePane.StandardAtmosphere;
                default:
                    return ReferencePane.None;
            }
        }
    }
}