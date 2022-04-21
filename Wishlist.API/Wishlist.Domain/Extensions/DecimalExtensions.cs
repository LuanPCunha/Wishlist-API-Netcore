using System.Text.RegularExpressions;

namespace Wishlist.Domain.Extensions
{
    public static class DecimalExtensions
    {
        public static int Size(this decimal attribute)
        {
            var attrStr = attribute.ToString();

            if (!attrStr.Contains("."))
            {
                attrStr += ".00";
            }

            return Regex.Replace(attrStr, @"[^\d]", "").Length;
        }

    }
}