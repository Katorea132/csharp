using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int amount;

        for (amount = 0; amount < n; amount++)
        {
            try
            {
                Console.WriteLine(myList[amount]);
            }
            catch
            {
                return amount;
            }
        }
        return amount;
    }
}
