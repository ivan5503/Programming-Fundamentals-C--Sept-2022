using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count/2; i++)
            {

                int sum = 0;
                sum = numbers[i] + numbers[(numbers.Count - 1) - i];
               

                result.Add(sum);
            }
            int middleElement = 0;
            if (numbers.Count % 2 != 0)
            {
                middleElement = numbers[(numbers.Count - 1) / 2];
                result.Add(middleElement);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
