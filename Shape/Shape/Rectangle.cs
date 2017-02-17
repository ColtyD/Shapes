using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Properties:
 * length
 * width
 * 
 * COnstructors:
 *Rectangle(double length, double width, int x=0, int y=0)
 * 
 * */


namespace Shape
{
    class Rectangle : Quadrilateral
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public override double Area
        {
            get
            {
                double area = Length * Width;
                return area; 
            }
        }

        public override double Perimeter
        {
            get
            {
                double perimeter = (Length * 2) + (Width * 2);
                return perimeter;
            }
        }

        public Rectangle(double length, double width, int x=0, int y = 0) : base(x,y)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            return $"Length: {Length}; Width: {Width}; Center: {Center}";
        }

    }
}
