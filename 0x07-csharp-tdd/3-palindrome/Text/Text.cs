using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;
using System;

namespace Text
{
    /// <summary>
    /// This class has a method to check for palindromes.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks for palindromes, ignores punctuation and spaces.
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>true or false depending if palindrome or not</returns>
        public static bool IsPalindrome(string s)
        {
            if (s.Length != 0)
            {
                string stringy = Regex.Replace(s, @"[^\w]", string.Empty);
                stringy = stringy.ToLower();
                string reversed = "";
                for (int lenghty = stringy.Length - 1; lenghty >= 0; lenghty--)
                    reversed += stringy[lenghty];
                for (int i = stringy.Length - 1; i >= 0; i--)
                    if (reversed[i] != stringy[i])
                        return false;
            }
            return true;

        }
    }
}
