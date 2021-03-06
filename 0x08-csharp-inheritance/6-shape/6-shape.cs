using System;

///<summary> Represent a shape </summary>
    class Shape
    {
	///<summary> area of a shape </summary>    
        public virtual int Area()
        {
            throw new NotImplementedException("Area() is not implemented");
        }
    }

    ///<summary> Represents a rectangle </summary>
    class Rectangle : Shape
    {
        private int width;
        private int height;
        
	///<summary> Gets or sets width </summary>
	public int Width {
            get => this.width;
            set {
                if (value < 0)
                    throw new ArgumentException("Width must be greater than or equal to 0");
                else
                    this.width = value;
            }
        }
	///<summary> Get or set height </summary>
        public int Height {
            get => this.height;
            set {
                if (value < 0)
                    throw new ArgumentException("Height must be greater than or equal to 0");
                else
                    this.height = value;
            }
        }
    }

