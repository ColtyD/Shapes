using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Properties:
 * Side
 * 
 * Constructors:
 * Square(double side, int x=0, int y=0)
 * 
 * */


namespace Shape
{
    class Square : Rectangle
    {
        public double Side { get; set; }

        public override double Area
        {
            get
            {
                double area = Side * Side;
                return area;
            }
        }

        public override double Perimeter
        {
            get
            {
                double perimeter = Side*4;
                return perimeter;
            }
        }

        public Square(double side, int x=0, int y=0) : base(side, side, x, y)
        {
            Side = side;
        }

        public override string ToString()
        {
            return $"Sides: {Side}; Center: {Center}";
        }

    }
}
