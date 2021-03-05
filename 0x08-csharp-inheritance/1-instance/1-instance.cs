using System;

///<summary> Object class </summary>
class Obj
{
    ///<summary> Checks if the obj is an instance of array </summary>
    ///<return> True or False </return>
    public static bool IsInstanceOfArray(object obj)
    {
    	if (obj is Array || obj.GetType() == typeof(Array))
            return (true);
        else
       	    return (false);
    }
}
