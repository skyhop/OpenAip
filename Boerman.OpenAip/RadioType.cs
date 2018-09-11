using System;
using System.Collections.Generic;
using System.Text;

namespace Boerman.OpenAip
{
    public enum RadioType
    {
        AIRMET,
        APPROACH,
        APRON,
        ARRIVAL,
        ATIS,
        AWOS,
        CENTER,
        CTAF,
        DELIVERY,
        DEPARTURE,
        FIS,
        GLIDING,
        GROUND,
        ILS,
        INFO,
        LIGHTS,
        MILITARY,
        MULTICOM,
        /// <summary>
        /// Used for uncommon frequency types
        /// </summary>
        OTHER,
        RADAR,
        TOWER,
        UNICOM,
        VOLME
    }
}
