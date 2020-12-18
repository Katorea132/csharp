using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Checks the amount of words, separated by caps.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Method that does what I state above.
        /// </summary>
        /// <param name="s">The string to search.</param>
        /// <returns>Amount of words.</returns>
        public static int CamelCase(string s)
        {
            if (s != null && s.Length != 0)
            {
                var rx = new Regex(@"[A-Z]", RegexOptions.Compiled);
                var amount = rx.Split(s);
                if (amount.GetLength(0) > 0 && Regex.Match(amount[0], @"[a-z]").Success)                  
                    return amount.GetLength(0);
            }
            return 0;
        }
    }
}
