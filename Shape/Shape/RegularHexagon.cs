using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Properties:
 * Side
 * 
 * Constructors:
 * RegularHexagon(double side, int x=0, int y=0)
 * 
 * */


namespace Shape
{
    class RegularHexagon : Shape
    {
        public double Side { get; set; }

        public override double Area
        {
            get
            {
                double area = ((3*Math.Sqrt(3))/(2))*(Side * Side);
                return area; 
            }
        }

        public override double Perimeter
        {
            get
            {
                double perimeter = 6 * Side;
                return perimeter; 
            }
        }

        public RegularHexagon(double side, int x=0, int y = 0) : base(x, y)
        {
            Side = side;

        }

        public override string ToString()
        {
            return $"Sides: {Side}; Center: {Center}";
        }
    }
}
