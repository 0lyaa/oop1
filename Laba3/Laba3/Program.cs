using System;

namespace Laba3
{
    public class Program
    {
        public static void Main()
        {

            Console.Write("Enter side1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle a = new Rectangle(side1, side2);

            Console.WriteLine("Area is: " + a.getArea());
            Console.WriteLine("Perimeter is: " + a.getPerimeter());

        }
    }
}