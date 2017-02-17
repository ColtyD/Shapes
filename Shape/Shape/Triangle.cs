using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Properties:
 * Side 1
 * Side 2
 * Side 3
 * 
 * Constructors:
 * Triangle( double side 1, double side 2, double side 3, int x = 0, int y = 0)
 * Triangle(double base, double, height, int x=0, int y=0)
 * */


namespace Shape
{
    class Triangle : Shape    {
        public double Side1 { get; set; }

        public double Side2 { get; set; }

        public double Side3 { get; set; }

        public override double Area
        {
            get
            {
                double s = (Side1 + Side2 + Side3) / 2.0;
                return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3) );
            }
        }

        public override double Perimeter
        {
            get
            {
                return Side1 + Side2 + Side3;
            }
        }

        public Triangle(double side1, double side2, double side3, int x=0, int y = 0) : base(x,y)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

        }

        public override string ToString()
        {
            return $"Sides: {Side1}, {Side2}, {Side3}; Center: {Center}";
        }



    }
}
