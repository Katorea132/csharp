using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        if (myDict != null)
        {
            Dictionary<string, int> didi = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> items in myDict)
                didi[items.Key] = items.Value * 2;
            return didi;
        }
        return null;
    }
}
