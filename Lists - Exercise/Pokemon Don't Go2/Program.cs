using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());

            int sum = 0;
            int removedElement = 0;
            int lastElement = 0;
            int firstElement = 0;
            while (true)
            {


                if (index < 0)
                {
                    lastElement = numbers[numbers.Count - 1];
                    removedElement = numbers[0];
                    sum += removedElement;
                    numbers.RemoveAt(0);
                    numbers.Add(lastElement);
                    IncreasingAndDecreasingOperatins(numbers, removedElement);
                }
                else if (index > numbers.Count - 1)
                {
                    firstElement = numbers[0];
                    removedElement = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    sum += removedElement;
                    numbers.Add(firstElement);
                    IncreasingAndDecreasingOperatins(numbers, removedElement);
                }
                else if (index >= 0 || index <= numbers.Count - 1)
                {
                    removedElement = numbers[index];
                    sum += removedElement;
                    numbers.RemoveAt(index);
                    IncreasingAndDecreasingOperatins(numbers, removedElement);
                    
                }
                if (numbers.Count == 0)
                {
                    break;
                }
                index = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(sum);
        }

        private static void IncreasingAndDecreasingOperatins(List<int> numbers, int removedElement)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= removedElement)
                {
                    numbers[i] += removedElement;
                }
                else
                {
                    numbers[i] -= removedElement;
                }
            }
        }
    }
}
