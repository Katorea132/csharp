using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count != 0)
        {
            int number = myLList.First.Value;
            myLList.RemoveFirst();
            return number;
        }
        return 0;
    }
}
