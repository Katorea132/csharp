﻿using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i = 1; i < 101; i++)
            {
                if (i == 100)
                    Console.WriteLine("Buzz");
                else
                {
                    if (i % 5 == 0 && i % 3 == 0)
                        Console.Write("FizzBuzz ");
                    else if (i % 5 == 0)
                        Console.Write("Buzz ");
                    else if (i % 3 == 0)
                        Console.Write("Fizz ");
                    else
                        Console.Write($"{i} ");
                }
            }
        }
    }
}
