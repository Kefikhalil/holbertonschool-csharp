using System;

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
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
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
}

    ///<summary>Damage script</summary>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
	   damage = 0;
        {
            Console.WriteLine($"{name} takes 0 damage!");
            return;
        }
    }

    ///<summary>healing script</summary>
    public void HealDamage(float heal)
    {
        Console.WriteLine($"{this.name} heals {heal} HP!");
        if (heal < 0f)
        float newHp = this.hp + heal;
    }
}
