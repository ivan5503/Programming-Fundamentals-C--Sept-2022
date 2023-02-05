using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            double maxValue = double.MinValue;
            string biggestKeg = " ";
            for (int i = 1; i <= nLines; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > maxValue)
                {
                    maxValue = volume;
                    biggestKeg = model;
                }

            }
            Console.WriteLine(biggestKeg);

        }
    }
}
