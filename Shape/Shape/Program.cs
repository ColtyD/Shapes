using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Overview:
 * Shape (abstract class)
 *      Triangle
 *          RightTriangle
 *      Quadrilateral (abstract)
 *          Rectangle
 *              Square
 *          IsocelesTrapezoid
 *      Circle
 *      RegularHexagon
 *  
 *  Postion(struct)
 * 
 * 
 * */


namespace Shape
{  
    class Program
    {
       static int numberOfIncorrectChecks = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Test Triangle");
            TestTriangle();

            Console.WriteLine(" ");

            Console.WriteLine("Test Right Triangle");
            TestRightTriangle();

            Console.WriteLine(" ");

            Console.WriteLine("Test Quadrilateral");
            TestQuadrilateral();

            Console.WriteLine(" ");

            Console.WriteLine("Test Rectangle");
            TestRectangle();

            Console.WriteLine(" ");

            Console.WriteLine("Test Square");
            TestSquare();

            Console.WriteLine(" ");

            Console.WriteLine("Test Isosceles Trapezoid");
            TestIsoscelesTrapezoid();

            Console.WriteLine(" ");

            Console.WriteLine("Test Circle");
            TestCircle();

            Console.WriteLine(" ");

            Console.WriteLine("Test regular Hexagon");
            TestRegularHexagon();

            Console.WriteLine(" ");


            Console.WriteLine("Number of Incorrect Checks: " + numberOfIncorrectChecks);

            Console.ReadKey(); 

        }

        //Each of these tests will hane one with x,y = int,int and another x,y, not passed

        static void TestTriangle()
        {
            //   Triangle t = new Triangle();
            Triangle t = new Triangle(3, 4, 5, 0, 5);

            Console.WriteLine(t);
            Console.WriteLine("Area: " + t.Area);
            Check(t.Area, 6);

            Console.WriteLine("Perimeter: " + t.Perimeter);
            Check(t.Perimeter, 12);
    
            Triangle t2 = new Triangle(4, 5, 6);
            Console.WriteLine("Area: " + t2.Area);
            Check(t2.Area, 9.92156);

            Console.WriteLine("Perimeter: " + t2.Perimeter);
            Check(t2.Perimeter, 15);

            Console.WriteLine(t2);    

        }

        static void TestRightTriangle()
        {
            RightTriangle rt = new RightTriangle(3, 5, 0, 5);

            Console.WriteLine(rt);

            Console.WriteLine("Area: " + rt.Area);
               Check(rt.Area, 7.5);

            Console.WriteLine("Perimeter: " + rt.Perimeter);
               Check(rt.Perimeter, 13.83095);

            RightTriangle rt2 = new RightTriangle(4, 6);

            Console.WriteLine(rt2);

            Console.WriteLine("Area: " + rt2.Area);
               Check(rt2.Area, 12);

            Console.WriteLine("Perimeter: " + rt2.Perimeter);
               Check(rt2.Perimeter, 17.21110);
        }

        static void TestQuadrilateral()
        {
            // Can't instanciate an abstract class
            Console.WriteLine("Can't instantiate an abstract class.");
        }

        static void TestRectangle()
        {
            Rectangle r = new Rectangle(2, 2, 5, 6);

            Console.WriteLine(r);
            Console.WriteLine("Area: " + r.Area);
            Check(r.Area, 4);

            Console.WriteLine("Perimeter: " + r.Perimeter);
            Check(r.Perimeter, 8);


            Rectangle r2 = new Rectangle(4, 5);

            Console.WriteLine(r2);
            Console.WriteLine("Area: " + r2.Area);
            Check(r2.Area, 20);

            Console.WriteLine("Perimeter: " + r2.Perimeter);
            Check(r2.Perimeter, 18);


        }

        static void TestSquare()
        {
            Square s = new Square(4, 2, 3);
 
            Console.WriteLine(s);
            Console.WriteLine("Area: " + s.Area);
            Check(s.Area, 16);

            Console.WriteLine("Perimeter: " + s.Perimeter);
            Check(s.Perimeter, 16);

            Square s2 = new Square(3);

            Console.WriteLine(s2);
            Console.WriteLine("Area: " + s2.Area);
            Check(s2.Area, 9);
            Console.WriteLine("Perimeter: " + s2.Perimeter);
            Check(s2.Perimeter, 12);


        }

        static void TestIsoscelesTrapezoid()
        {
            IsoscelesTrapezoid it = new IsoscelesTrapezoid(2, 3, 4, 0 , 5);
            Console.WriteLine(it);
            Console.WriteLine("Area: " + it.Area);
            Check(it.Area, 10);
            Console.WriteLine("Perimeter: " + it.Perimeter);
            Check(it.Perimeter, 16.3137);

            IsoscelesTrapezoid it2 = new IsoscelesTrapezoid(4, 5, 6);
            Console.WriteLine(it2);
            Console.WriteLine("Area: " + it2.Area);
            Check(it2.Area, 27);
            Console.WriteLine("Perimeter: " + it2.Perimeter);
            Check(it2.Perimeter, 25.97056);

        }

        static void TestCircle()
        {
            Circle c = new Circle(4, 0, 5);
            Console.WriteLine(c);
            Console.WriteLine("Area: " + c.Area);
            Check(c.Area, 50.26548);
            Console.WriteLine("Circumference: " + c.Circumference);
            Check(c.Circumference, 25.1327);

            Circle c2 = new Circle(3);
            Console.WriteLine(c2);
            Console.WriteLine("Area: " + c2.Area);
            Check(c2.Area, 28.2743);
            Console.WriteLine("Circumference: " + c2.Circumference);
            Check(c2.Circumference, 18.8495);

        }

        static void TestRegularHexagon()
        {
            RegularHexagon rh = new RegularHexagon(4, 2, 3);
            Console.WriteLine(rh);
            Console.WriteLine("Area: " + rh.Area);
            Check(rh.Area, 41.5692);
            Console.WriteLine("Perimeter: " + rh.Perimeter);
            Check(rh.Perimeter, 24);

            RegularHexagon rh2 = new RegularHexagon(2);
            Console.WriteLine(rh2);
            Console.WriteLine("Area: " + rh2.Area);
            Check(rh2.Area, 10.3923);
            Console.WriteLine("Perimeter: " + rh2.Perimeter);
            Check(rh2.Perimeter, 12);

        }


        // Check to see if any of the returned numbers are passing anything different than what we expected
        static void Check(double actual, double expected)
        {
            if(Math.Abs(actual - expected) > 0.001)
            {
                numberOfIncorrectChecks++;
            }
        }

    }
}
