using System;
using System.Collections.Generic;

///<summary>Player class</summary>
public class Player
{
///player's name
    private string name;
/// player's maximum hp
    private float maxHp;
/// players's health 
    private float hp;

    ///<summary>Player Constructor</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100;
        }
        else
        this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }

    ///<summary>Prints the player health</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
    ///<summary>Damage script</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        float newHp = this.hp - damage;
	Console.WriteLine($"{this.name} takes {damage} damage!");
	this.ValidateHP(newHp);
    }

    ///<summary>Healing script</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        float newHp = this.hp + heal;
	Console.WriteLine($"{this.name} heals {heal} HP!");
	this.ValidateHP(newHp);
}
    ///<summary>Validation script</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
}
}
