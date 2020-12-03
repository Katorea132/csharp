using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        for (LinkedListNode<int> nodi = myLList.Last; nodi != null; nodi = nodi.Previous)
        {
            if (n > nodi.Value)
                return myLList.AddAfter(nodi, n);
            else if(nodi.Previous == null)
                return myLList.AddBefore(nodi, n);
        }
        return null;
    }
}
