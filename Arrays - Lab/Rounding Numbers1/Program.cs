using System;
using System.Linq;

namespace Rounding_Numbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            double[] numbers = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                 numbers[i] = double.Parse(input[i]);
            }

            for (int j = 0; j < numbers.Length;j++)
            {
                Console.WriteLine("{0} => {1}", numbers[j], (int)Math.Round(numbers[j],MidpointRounding.AwayFromZero));
            }
        }
    }
}
