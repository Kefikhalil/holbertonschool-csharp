using System;

/// <summary>base class </summary>
abstract class Base{
    public string name {get; set;}
    /// <summary> Override string </summary>
    public override string ToString(){
        return ($"{name} is a {this.GetType()}");
    }
}
/// <summary>Interactive interface</summary>
interface IInteractive
{
    void Interact();
}
/// <summary>IBreakable interface</summary>
interface IBreakable
{
    int durability {get; set;}
    void Break();
}

/// <summary> ICollectable interface</summary>
interface ICollectable
{
    bool isCollected {get; set;}
    void Collect();
}
/// <summary>test</summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability {get; set;}
    public bool isCollected {get;set;}
    public void Interact()
    {

    }
    public void Break()
    {

    }
    public void Collect()
    {

    }
}
