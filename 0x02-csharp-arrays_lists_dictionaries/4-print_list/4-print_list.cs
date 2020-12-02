using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size >= 0)
        {
            List<int> lili = new List<int>();

            for(int i = 0; i < size; i++)
            {
                lili.Add(i);
                if (i == size - 1)
                    Console.Write(i);
                else
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
            return lili;
        }
        Console.WriteLine("Size cannot be negative");
        return null;
    }
}
