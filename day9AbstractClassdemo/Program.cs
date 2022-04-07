using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9AbstractClassdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle(10, 20);
            double area = shape.GetArea();
            double perimeter = shape.GetPerimeter();

            Console.WriteLine("the area is {0}, perimeter is {1}",area,perimeter);

            Shape shape2 = new Circle(10);

            double area2 = shape2.GetArea();
            double p2 = shape2.GetPerimeter();
            Console.WriteLine("area of the circle is {0},perimeter of the circle is {1}",area2,p2);




            Console.ReadLine();
        }
    }
}
