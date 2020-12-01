using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            int i;
            for(i = 0; i < 26; i++, letter++)
            {
                if (letter != 'e' && letter != 'q')
                    Console.Write(letter);
            }
        }
    }
}
