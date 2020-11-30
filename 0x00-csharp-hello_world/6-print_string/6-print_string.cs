using System;

namespace _6_print_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Holberton School";
            Console.WriteLine($"{str}{str}{str}\n{str.Substring(0,9)}");
        }
    }
}
