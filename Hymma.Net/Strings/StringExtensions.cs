using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hymma.Net
{
    /// <summary>
    /// helper extension methodes for <see cref="string"/>s
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// gets the right hand side of a specific string in a string
        /// </summary>
        /// <param name="fullText"></param>
        /// <param name="border"></param>
        /// <returns></returns>
        public static string GetRightSide(this string fullText, string border)
        {
            var chars = border.ToCharArray();
            var lastChar = chars[chars.Length - 1];
            return fullText.Substring(fullText.IndexOf(lastChar) + 1).Trim();
        }

        /// <summary>
        /// get the left hand side of a specific string in another one
        /// </summary>
        /// <param name="fullText"></param>
        /// <param name="border"></param>
        /// <returns></returns>
        public static string GetLeftSide(this string fullText, string border)
        {
            var chars = border.ToCharArray();
            var firstChar = chars[0];
            return fullText.Substring(0, fullText.IndexOf(firstChar) - 1).Trim();
        }
    }
}
