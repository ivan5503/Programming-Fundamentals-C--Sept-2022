using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sum = currNumber + numbers[j];

                    if (sum == num)
                    {
                        Console.WriteLine("{0} {1}", currNumber, numbers[j]);
                    }
                }
                
            }
        }
    }
}
