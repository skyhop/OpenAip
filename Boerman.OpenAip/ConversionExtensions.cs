using System;
using System.Collections.Generic;
using System.Text;

namespace Boerman.OpenAip
{
    public static class ConversionExtensions
    {
        public static TEnum Parse<TEnum>(object value, TEnum fallback) where TEnum : struct, Enum 
            => Enum.TryParse<TEnum>(value.ToString(), out var res) ? res : fallback;

        public static decimal? ToNullableDecimal(string value)
        {
            if (value == null)
                return null;

            if (decimal.TryParse(value, out var res))
                return res;

            return null;
        }

        public static bool? ToNullableBoolean(string value)
        {
            if (value == null)
                return null;

            if (bool.TryParse(value, out var res))
                return res;

            return null;
        }
    }
}
