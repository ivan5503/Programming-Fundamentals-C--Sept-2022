using System;

namespace Rounding_Numberss
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] numbers = new double[input.Length];

            for (int i = 0; i <= input.Length - 1; i++)
            {
                numbers[i] = double.Parse(input[i]); 
            }
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }

        }
    }
}