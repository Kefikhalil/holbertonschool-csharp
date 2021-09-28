using System;


///<summary>Base class.</summary>
public abstract class Base
{
public string name;
    public override string ToString()
    {
        return ($"{this.name} is a {this.GetType()}");
}
