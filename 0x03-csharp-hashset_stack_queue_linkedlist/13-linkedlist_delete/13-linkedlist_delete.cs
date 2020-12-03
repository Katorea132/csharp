using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> nodi = myLList.First;

        for (int i = 0; nodi != null; nodi = nodi.Next, i++)
            if (i == index)
                myLList.Remove(nodi);
    }
}
