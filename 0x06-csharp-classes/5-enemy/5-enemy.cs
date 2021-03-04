using System;

namespace Enemies
{
    ///<summary> Represents a zombie class  ///</summary>
    public class Zombie
    {
        ///<summary> Represent the zombie health </summary>
	private int health;
	///<summary> Name of a zombie ///</summary>
        private string name = "(No name)";
	///<summary> Represent the zombie constructor ///</summary>
        public Zombie()
        {
            health = 0;
        }
            ///<summary> New instance of a zombie ///</summary>
        public Zombie (int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
	        ///<summary> Return the zombie current health </summary>
        public int GetHealth()
        {
            return (health);
        }
	        ///<summary>Retrieve or sets the name </summary>
                        
	public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
	        ///<summary> Override that prints the Zombie object’s attributes to stdout </summary>
        public override string ToString()
        {
            return String.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}
