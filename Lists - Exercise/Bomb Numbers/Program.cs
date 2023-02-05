using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            string[] tokens = command.Split();

            int bombNumber = int.Parse(tokens[0]);
            int power = int.Parse(tokens[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                int target = numbers[i];
                if (target == bombNumber)
                {
                    Detonate(numbers, i, power);
                }
            }
            
            Console.WriteLine(numbers.Sum());
                
            
        }

        private static void Detonate(List<int> numbers, int index, int power)
        {
            int start = Math.Max(0, index - power);
            int end = Math.Min(numbers.Count - 1, index + power);

            for (int i = start; i <= end; i++)
            {
                numbers[i] = 0;
            }
        }
    }
}
