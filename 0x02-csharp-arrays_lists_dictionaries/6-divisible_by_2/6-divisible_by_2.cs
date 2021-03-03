using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> List = new List<bool>();
        foreach (int num in myList)
        {
            if (num % 2 == 0)
                myList.Add(true);
            else
                myList.Add(false);
        }
        return (myList);
    }
}
