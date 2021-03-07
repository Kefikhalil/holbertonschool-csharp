using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int list2 = 0;
        List<int> newList = myList;
        newList.Sort();
        for (int i = 0; i < newList.Count; i++)
        {
            if (i == 0 || newList[i] != newList[i - 1])
                list2 += newList[i];
        }
        return (list2);
    }
}
