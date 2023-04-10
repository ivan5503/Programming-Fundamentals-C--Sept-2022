using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split().Select(long.Parse).ToList();
            string command = string.Empty;


            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "swap":
                        int firstIndex = int.Parse(tokens[1]);
                        int secondIndex = int.Parse(tokens[2]);
                        Swap(numbers, firstIndex, secondIndex);
                        break;
                    case "multiply":
                        firstIndex = int.Parse(tokens[1]);
                        secondIndex = int.Parse(tokens[2]);
                        Multiply(numbers, firstIndex, secondIndex);
                        break;
                    case "decrease":
                        int decrease = 1;
                        DecreaseAllElements(numbers, decrease);
                        break;
                }

            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        static void DecreaseAllElements(List<long> numbers, int decrease)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] -= decrease;
            }
        }

        static void Multiply(List<long> numbers, int firstIndex, int secondIndex)
        {
            long element1 = numbers[firstIndex];
            long element2 = numbers[secondIndex];
            numbers.Remove(element1);
            long result = element1 * element2;
            numbers.Insert(firstIndex, result);

        }

        static void Swap(List<long> numbers, int firstIndex, int secondIndex)
        {
            int lower = Math.Min(firstIndex, secondIndex);
            int bigger = Math.Max(firstIndex, secondIndex);
            long element1 = numbers[lower];
            long element2 = numbers[bigger];
            numbers.Remove(element1);
            numbers.Remove(element2);
            numbers.Insert(lower, element2);
            numbers.Insert(bigger, element1);
        }
    }
}
