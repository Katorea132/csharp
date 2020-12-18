using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Contains something that searches for the max number in a list.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Finds the max.
        /// </summary>
        /// <param name="nums">List of numbers.</param>
        /// <returns>Max number or 0 if invalid list.</returns>
        public static int Max(List<int> nums)
        {
            int number = 0;

            if (nums != null && nums.Count != 0)
            {
                number = nums[0];
                for (int i = 1; i < nums.Count; i++)
                    if (number < nums[i])
                        number = nums[i];
            }
            return number;
        }
    }
}
