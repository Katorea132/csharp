using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> lili = new List<bool>();

        foreach (int number in myList)
        {
            if (number % 2 == 0)
                lili.Add(true);
            else
                lili.Add(false);
        }
        return lili;
    }
}
