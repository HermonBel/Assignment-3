using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Shape
    {
        public abstract double claculateArea();
        public abstract double claculatePerimeter();
    }

    class Circle : Shape
    {
        double radius = 5;
        static readonly double PI = 3.14;
        public override double claculateArea()
        {
            return PI * radius * radius;
        }

        public override double claculatePerimeter()
        {
            return 2 * PI * radius;
        }
    }

    class Rectangle : Shape
    {
        double length = 5, width = 5;

        public override double claculateArea()
        {
            return length * width;
        }

        public override double claculatePerimeter()
        {
            return 2 * (length + width);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape c = new Circle();
            Shape r = new Rectangle();
            Console.WriteLine("Area and perimeter of a 5cm radius cicle is " + c.claculateArea() + "cm sqaure and " + c.claculatePerimeter() + "cm");
            Console.WriteLine("Area and perimeter of 5cm length and width rectangle is " + r.claculateArea() + "cm sqaure and " + r.claculatePerimeter() + "cm" );
            Console.ReadKey();
        }
    }
}
