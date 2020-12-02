using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arry = new int[5, 5];

            arry[2, 2] = 1;
            for(int i = 0; i < arry.GetLength(0); i++)
                for(int j = 0; j < arry.GetLength(1); j++)
                {
                    if (j != arry.GetLength(1) - 1)
                        Console.Write($"{arry[i, j]} ");
                    else
                        Console.WriteLine(arry[j,i]);
                }
        }
    }
}
