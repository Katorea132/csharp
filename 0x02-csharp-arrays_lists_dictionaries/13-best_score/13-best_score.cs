using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int hi = 0;
        string key = "None";

        foreach (KeyValuePair<string, int> item in myList)
        {
            if (item.Value >= hi)
            {
                hi = item.Value;
                key = item.Key;
            }
        }

        return key;
    }
}
