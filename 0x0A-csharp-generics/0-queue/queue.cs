using System;

///<summary>Generic queue</summary>
public class Queue<T>
{
    ///<summary>Type check</summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }
}
