using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index >= 0 && index < myList.Count)
            myList.Remove(index + 1);
        else
            Console.WriteLine("Index is out of range");
        return myList;
    }
}
