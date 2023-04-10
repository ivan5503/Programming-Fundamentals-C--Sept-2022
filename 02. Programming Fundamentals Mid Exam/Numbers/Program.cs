using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(numbers);
            List<int> topNumbers = new List<int>();

            double averageNumber = numbers.Sum();
            averageNumber = averageNumber / numbers.Length;
            int counter = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {

                if (numbers[i] > averageNumber)
                {
                    counter++;
                    if (counter > 5)
                    {
                        break;
                    }
                    topNumbers.Add(numbers[i]);

                }



            }
            if (topNumbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", topNumbers));
            }
        }
    }
}
