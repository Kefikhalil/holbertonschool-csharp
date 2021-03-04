using System;

namespace Enemies
{
    ///<summary> Represents a zombie class  ///</summary>
    public class Zombie
    {
        ///<summary> Represent the zombie health </summary>
	public int health;
	///<summary> Represent the zombie constructor </summary>
        public Zombie()
        {
            health = 0;
        }
            ///<summary> New instance of a zombie </summary>
        public Zombie (int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
    }
}
