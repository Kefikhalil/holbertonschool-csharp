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
public interface IInteractive{
    /// <summary>interactions </summary>
    void Interact();
}
/// <summary>IBreakable</summary>
public interface IBreakable{
    /// <summary>Used for item durability</summary>
    int durability {get; set;}
    /// <summary>Used to break an item</summary>
    void Break();
}
/// <summary>ICollectable interface</summary>
public interface ICollectable{
    /// <summary>Used to check if collected or not</summary>
    bool isCollected {get; set;}
    /// <summary>Used to collect something</summary>
    void Collect();
}
/// <summary>Used for test purpose</summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable{

    /// <summary>Used for item durability</summary>
    public int durability {get; set;}
    /// <summary>Used for collection</summary>
    public bool isCollected {get; set;}
    /// <summary>Used for interaction</summary>
    public void Interact(){
    }
    /// <summary>Used to break item</summary>
    public void Break(){
    }

    /// <summary>Used to collect something</summary>
    public void Collect(){
    }
}
