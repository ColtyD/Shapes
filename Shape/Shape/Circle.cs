using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Properties:
 * radius
 * diameter
 * Circumference( read-only, same as Perimeter )
 * 
 * Constructors:
 * Circle(double radius, int x=0, int y=0)
 * 
 * */


namespace Shape
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public double Diameter { get; set; }

        public double Circumference { get; }

        public override double Area
        {
            get
            {
                double area = Math.PI * (Radius * Radius);
                return area; 
            }
        }

        public override double Perimeter
        {
            get
            {
                double perimeter =  2 * Math.PI * Radius;
                return perimeter;
            }
        }

        public Circle(double radius, int x=0, int y = 0) : base(x, y)
        {
            Radius = radius;
            Diameter = 2 * radius;
            Circumference = 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"Radius: {Radius}; Diameter: {Diameter}; Circumference: {Circumference}";
        }

    }
}
