using System;
using System.ComponentModel;
using System.Globalization;

namespace Boerman.OpenAip
{
    [Flags]
    public enum AirspaceCategory
    {
        None = 0,
        A = 1,
        B = 2,
        C = 4,
        CTR = 8,
        D = 16,
        Danger = 32,
        E = 64,
        F = 128,
        G = 256,
        Gliding = 512,
        Other = 1024,
        Restricted = 2048,
        TMA = 4096,
        TMZ = 8192,
        Wave = 16384,
        Prohibited = 32768,
        FIR = 65536,
        UIR = 131072,
        RMZ = 262144
    }
}
