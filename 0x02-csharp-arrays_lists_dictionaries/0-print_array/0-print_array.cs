using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size >= 0)
        {
            int[] arry = new int[size];

            for (int i = 0; i < arry.Length; i++)
            {
                arry[i] = i;
                if (i != arry.Length - 1)
                    Console.Write($"{arry[i]} ");
                else
                    Console.Write(arry[i]);
            }
            Console.WriteLine();
            return arry;
        }
        Console.WriteLine("Size cannot be negative");
        return null;
    }
}
