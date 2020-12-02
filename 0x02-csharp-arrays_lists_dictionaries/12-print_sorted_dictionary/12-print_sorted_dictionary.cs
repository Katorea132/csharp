using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> lili = new List<string>(myDict.Keys);
        lili.Sort();

        foreach (string key in lili)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}
