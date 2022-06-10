using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealer.Data.Constants
{
    public static class Extensions
    {
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        public static bool IsNull<T>(this T obj)
        {
            return obj == null;
        }

        public static bool IsNull(this string value)
        {
            return value == null;
        }

        public static int? ToIntOrNull(this string value)
        {
            int i;
            if (int.TryParse(value, out i))
            {
                return i;
            }

            return null;
        }

        public static long? ToLongOrNull(this string value)
        {
            long i;
            if (long.TryParse(value, out i))
            {
                return i;
            }

            return null;
        }

        public static string SafeTrim(this string value)
        {
            return !string.IsNullOrEmpty(value) ? value.Trim() : value;
        }
        public static string NullIsBlank(this string value)
        {
            return !string.IsNullOrEmpty(value) ? value.Trim() : "";
        }
        public static decimal NullIsZero(this decimal value)
        {
            return value.Equals(null) ? 0 : value;
        }

        public static bool IsNullOrBlank(this string text)
        {
            return text == null || text.Trim().Length == 0;
        }
    }
}
