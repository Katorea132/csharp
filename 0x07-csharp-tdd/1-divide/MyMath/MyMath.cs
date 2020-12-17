using System;

namespace MyMath
{
    /// <summary>
    /// Class that contains a method to divide a matrix.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides a matrix.
        /// </summary>
        /// <param name="matrix">The matrix to divide.</param>
        /// <param name="num">The number to divide with.</param>
        /// <returns>The new matrix with results or null if invalid.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num != 0)
            {
                if (matrix != null)
                {
                    int [,] res = new int[matrix.GetLength(0), matrix.GetLength(1)];

                    for (int i = 0; i < matrix.GetLength(0); i++)
                        for (int j = 0; j < matrix.GetLength(1); j++)
                            res[i, j] = matrix[i, j] / num;
                    return res;
                }
                return null;
            }
            Console.WriteLine("Num cannot be 0");
            return null;
        }
    }
}
