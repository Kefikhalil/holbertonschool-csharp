using System;

/// <summary>base class </summary>
abstract class Base{
    public string name {get; set;}
    /// <summary> Override string </summary>
    public override string ToString(){
        return $"{name} is a {this.GetType()}";
    }
}
