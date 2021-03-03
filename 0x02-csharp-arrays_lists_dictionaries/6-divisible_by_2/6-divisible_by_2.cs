using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> List)
    {
        List<bool> List = new List<bool>();
        foreach (int num in List)
        {
            if (num % 2 == 0)
                myList.Add(true);
            else
                myList.Add(false);
        }
        return (myList);
    }
}
