using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                int index = 0;
                int element = 0;
                string[] tokens = command.Split();

                if (tokens.Length == 3)
                {

                    index = int.Parse(tokens[1]);
                    element = int.Parse(tokens[2]);
                    numbers.Insert(element,index);
                }
                else
                {
                    element = int.Parse(tokens[1]);
                    if (numbers.Contains(element))
                    {
                       RemoveAllElementsEqualToTheGivenElement(numbers, element);
                    }
                    
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));

        }

        static void RemoveAllElementsEqualToTheGivenElement(List<int> numbers, int element)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == element)
                {
                    numbers.Remove(element);
                    i--;
                }
            }
        }
    }
}

