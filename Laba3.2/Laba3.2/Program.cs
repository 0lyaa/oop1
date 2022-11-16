using Laba3._2;
using System;

namespace Laba3
{
    public class Program
    {
        public static void Main()
        {
            Figure figure = new Figure(new Point("A", 2, 3), new Point("B", 4, 6), new Point("C", 6, 2));
            figure.PerimeterCalculator();

            Figure figure2 = new Figure(new Point("A", 2, 3), new Point("B", 4, 6), new Point("C", 6, 2), new Point("D", 4, 1));
            figure2.PerimeterCalculator();

            Figure figure3 = new Figure(new Point("A", 2, 3), new Point("B", 4, 6), new Point("C", 6, 2), new Point("D", 5, 1), new Point("E", 2, 0));
            figure3.PerimeterCalculator();
        }
    }
}