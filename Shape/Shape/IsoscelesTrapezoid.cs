using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Properties:
 * Base1
 * Base2
 * Altitude
 * 
 * Constructors:
 * IsoscelesTrapezoid(double base1, double base2, double altitude, int x=0, int y=0)
 * 
 * 
 * */


namespace Shape
{
    class IsoscelesTrapezoid : Quadrilateral
    {
        public double Base1 { get; set; }

        public double Base2 { get; set; }

        public double Altitude { get; set; }

        public override double Area
        {
            get
            {
                double area = 0.5 * (Base1 + Base2) * Altitude;
                return area;
            }
        }

        public override double Perimeter
        {
            get
            {
                double topBase;
                double bottomBase;
                if (Base1 < Base2)
                {
                    topBase = Base1;
                    bottomBase = Base2;

                }
                else {
                    topBase = Base2;
                    bottomBase = Base1; 
                }

                double perimeter = topBase + Altitude * Math.Sqrt(2) + bottomBase + Altitude * Math.Sqrt(2);

                return perimeter;
               
            }
        }

        public IsoscelesTrapezoid(double base1, double base2, double altitude, int x = 0, int y = 0) : base(x, y)
        {
            Base1 = base1;
            Base2 = base2;
            Altitude = altitude;
        }

        public override string ToString()
        {
            return $"Sides: {Base1}, {Base2}; Altitute: {Altitude}; Center: {Center}";
        }
    }
}
