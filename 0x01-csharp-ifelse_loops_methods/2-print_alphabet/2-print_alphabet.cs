﻿using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            int i;
            for(i = 0; i < 26; i++, letter++)
                Console.Write(letter);
        }
    }
}
