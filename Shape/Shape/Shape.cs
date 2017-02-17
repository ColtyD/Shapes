using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Position Center 
//Absztract doube Area (read-only)
//abstract double Perimeter (IReadOnlyCollection-only)
/*Contructors:
 * Shape(int x, int y)
 * Shape()
 * Set center position to (0,0)
 * Shape(position p) 
    */

namespace Shape
{
   abstract class Shape
    {
        public int PositionCenter { get; set; }

        public abstract double Area { get; }

        public abstract double Perimeter { get; }

        public Position Center { get; set; }

        public Shape(int x = 0, int y = 0) : this( new Position(x,y) )
        {

        }

        public Shape(Position p)
        {
            Center = p;
        }


    }
}
