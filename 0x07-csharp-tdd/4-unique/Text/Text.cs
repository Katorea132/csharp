using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// A class to determine the index of the first unique character is it has one.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// The method to surpass Metal Gear.
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>The place that surpased Metal Gear.</returns>
        public static int UniqueChar(string s)
        {
            if (s != null && s.Length != 0)
            {
                int[] letters = new int[26];
                foreach (char letter in s.ToArray())
                    letters[letter - 'a'] += 1;
                for (int i = 0; i < s.Length; i++)
                    if (letters[s[i] - 'a'] == 1)
                        return i;
            }
            return -1;
        }
    }
}
