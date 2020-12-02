using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggy =
            {
                new int[] { 0, 1, 2, 3 },
                new int[] { 0, 1, 2, 3, 4, 5, 6 },
                new int[] { 0, 1 }
            };
            for (int i = 0; i < jaggy.Length; i++)
                for (int j = 0; j < jaggy[i].Length; j++)
                {
                    if (j != jaggy[i].Length - 1)
                        Console.Write($"{jaggy[i][j]} ");
                    else
                        Console.WriteLine(jaggy[i][j]);
                }
        }
    }
}
