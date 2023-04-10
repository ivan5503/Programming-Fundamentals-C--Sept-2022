using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            FindAndPrintLongerLIne(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void FindAndPrintLongerLIne(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
           
            double lengthFirstLine = (Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double lengthSecondLine = (Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));

            if (lengthFirstLine >= lengthSecondLine)
            {
                StartWithPointCloserToCenter(x1, y1, x2, y2);
            }
            else
            {
                StartWithPointCloserToCenter(x3, y3, x4, y4);
            }
        }

        private static void StartWithPointCloserToCenter(double x1, double y1, double x2, double y2)
        {
            if (Math.Pow(x1,2) + Math.Pow(y1,2) <= Math.Pow(x2,2) + Math.Pow(y2,2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
