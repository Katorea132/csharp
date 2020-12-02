using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList != null && myList.Count != 0)
        {
            int hi = myList[0];
            for (int i = 1; i < myList.Count; i++)
                if (hi < myList[i])
                    hi = myList[i];
            return hi;
        }
        Console.WriteLine("List is empty");
        return -1;

    }
}
