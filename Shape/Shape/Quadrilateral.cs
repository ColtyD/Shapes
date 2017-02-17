using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* (Abstract)
 * 
 * Properties:
 * Side 1
 * Side 2
 * Side 3
 * Side 4
 * 
 * Constructors:
 * Quadrilateral(int x=0, int y=0)
 * 
 * */


namespace Shape
{
   abstract class Quadrilateral : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Side4 { get; set; }

        public Quadrilateral(int x=0, int y = 0) : base(x, y)
        {
           
        }

        public override string ToString()
        {
            return $"Sides: {Side1}, {Side2}, {Side3}, {Side4}; Center: {Center}";
        }

    }
}
