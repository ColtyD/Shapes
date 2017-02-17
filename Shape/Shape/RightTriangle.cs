using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Properties:
 * Hypotenuse
 * Base
 * Height
 * 
 * Constructors:
 * RightTringle(double base, doube height, int x=0, int y=0)
 * 
 * */ 


namespace Shape
{
    class RightTriangle : Triangle
    {

        public double Hypotenuse
        {
            get
            {
                return Side3;
            }
            
        }

        public double Base
        {
            get
            {
                return Side1;
            }
            set
            {
                Side1 = value;
                Side3 = Math.Sqrt(Base * Base + Height * Height);
            }
        }

        public double Height
        {
            get
            {
                return Side2;
            }
            set
            {
                Side2 = value;
                Side3 = Math.Sqrt(Base * Base + Height * Height);
            }
        }


        public RightTriangle(double b, double h, int x=0, int y=0) : base(b, h, 0, x, y)
        {
            Base = b;
            Height = h;
        }

        public override string ToString()
        {
            return $"Base: {Base}; Height: {Height}; Center: {Center}";
        }

    }
}
