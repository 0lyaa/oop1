using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3._2
{
    internal class Figure
    {
        Point[] points;

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[3];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[4];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[5];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            points[4] = p5;
        }

        static double LengthSide(Point A, Point B)
        {
            double length = Math.Sqrt(Math.Pow(B.GetX() - A.GetX(), 2) + Math.Pow(B.GetY() - A.GetY(), 2));
            return length;
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;


            if (points.Length == 3)
            {

                perimeter = LengthSide(points[0], points[1]) + LengthSide(points[1], points[2]) + LengthSide(points[0], points[2]);
                Console.WriteLine("Triangle: " + Math.Round(perimeter, 3) + "cm");
            }

            else if (points.Length == 4)
            {
                perimeter = LengthSide(points[0], points[1]) + LengthSide(points[1], points[2]) + LengthSide(points[2], points[3]) + LengthSide(points[0], points[3]);
                Console.WriteLine("Quadrangle: " + Math.Round(perimeter, 3) + "cm");
            }

            else if (points.Length == 5)
            {
                perimeter = LengthSide(points[0], points[1]) + LengthSide(points[1], points[2]) + LengthSide(points[2], points[3]) + LengthSide(points[3], points[4]) + LengthSide(points[0], points[4]);
                Console.WriteLine("Pentagon: " + Math.Round(perimeter, 3) + "cm");
            }

        }


    }
}
