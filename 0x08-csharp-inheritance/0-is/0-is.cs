using System;

///<summary> returns True if the object is an int, otherwise return False ///</summary>
class Obj
{
    ///<summary> Checks if type is int </summary>
    ///<returns> True or False </returns>
    public static bool IsOfTypeInt(object obj)
    {
    	if (obj.GetType() == typeof(int))
            return (true);
        else
            return (false);
    }
}
