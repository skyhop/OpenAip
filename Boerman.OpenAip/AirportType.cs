using System;
using System.Collections.Generic;
using System.Text;

namespace Boerman.OpenAip
{
    public enum AirportType
    {
        /// <summary>
        /// Aerodrome Closed
        /// </summary>
        AD_CLOSED,
        /// <summary>
        ///  Military Aerodrome
        /// </summary>
        AD_MIL,
        /// <summary>
        /// Airfield Civil
        /// </summary>
        AF_CIVIL,
        /// <summary>
        /// Airfield (civil/military)
        /// </summary>
        AF_MIL_CIVIL,
        /// <summary>
        /// Water Airfield
        /// </summary>
        AF_WATER,
        /// <summary>
        /// Airport resp. Airfield IFR
        /// </summary>
        APT,
        /// <summary>
        /// Glider Site
        /// </summary>
        GLIDING,
        /// <summary>
        /// Heliport Civil
        /// </summary>
        HELI_CIVIL,
        /// <summary>
        /// Heliport Military
        /// </summary>
        HELI_MIL,
        /// <summary>
        /// International Airport
        /// </summary>
        INTL_APT,
        /// <summary>
        /// Ultra Light Flying Site
        /// </summary>
        LIGHT_AIRCRAFT
    }
}
