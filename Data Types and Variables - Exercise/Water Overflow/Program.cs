using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int capacity = 255;

            int litersOfWater = 0;
            int quantityOfLiters = 0;
            for (int i = 1; i <= nLines; i++)
            {
                quantityOfLiters += litersOfWater = int.Parse(Console.ReadLine());
                if (quantityOfLiters > capacity)
                {
                    quantityOfLiters -= litersOfWater;
                    Console.WriteLine("Insufficient capacity!");
                }
        

            }
            Console.WriteLine(quantityOfLiters);

        }
    }
}
