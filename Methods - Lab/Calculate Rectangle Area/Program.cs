using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Maioln(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetRectangleArea(width, height);
            Console.WriteLine(area);

        }
        static double GetRectangleArea(double width, double height)
        {
           double area = width * height;
            return area;
        }
    }
}
