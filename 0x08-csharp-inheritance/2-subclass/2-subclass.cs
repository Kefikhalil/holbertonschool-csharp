using System;

///<summary> Checks type </summary>
    class Obj
    {
	///<summary> checks if type is subclass </summary>
	///<returns>true or false </returns>
        public static bool IsOnlyASubclass(Type derivedType, Type baseType)
        {
            if (!(derivedType != baseType && derivedType.IsSubclassOf(baseType)))
                return (false);
            else
                return (true);
        }
    }
