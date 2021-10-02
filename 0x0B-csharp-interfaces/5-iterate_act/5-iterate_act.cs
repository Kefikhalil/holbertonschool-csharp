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
class Door : Base, IInteractive
{

    public Door(string Name = "Door")
    {
	name = Name;
}
/// <summary>interact</summary>

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
/// <summary>decoration class</summary>

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability {get; set;}

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 1)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
/// <summary>interact</summary>

    public void Interact()
    {
        if (durability < 1)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem == true)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }
   /// <summary>break</summary>
    public void Break()
    {
        durability -= 1;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else if (durability < 0)
            Console.WriteLine($"The {name} is already broken.");
    }
}
 /// <summary>key class</summary>
class Key : Base, ICollectable
{
    public bool isCollected {get;set;}

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
/// <summary>collect </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else{
            Console.WriteLine($"You have already picked up the {name}.");
	}
    }
}
 /// <summary>Room objects class</summary>
public class RoomObjects{
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        
        foreach (Base objct in roomObjects)
        {
            if (type == typeof(IInteractive) && objct is IInteractive)
                ((IInteractive)objct).Interact();
            if (type == typeof(IBreakable) && objct is IBreakable)
                ((IBreakable)objct).Break();
            if (type == typeof(ICollectable) && objct is ICollectable)
                ((ICollectable)objct).Collect();
        }
    }
}
