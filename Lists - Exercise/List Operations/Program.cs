using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            int element = 0;
            int index = 0;
            int count = 0;
            while (command != "End")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "Add":
                        element = int.Parse(tokens[1]);
                        ListOperationAdd(numbers, element);
                        break;
                    case "Insert":
                        element = int.Parse(tokens[1]);
                        index = int.Parse(tokens[2]);
                        ListOperationInsert(numbers, element, index);
                        break;
                    case "Remove":
                        index = int.Parse(tokens[1]);
                        ListOperationRemove(numbers,index);
                        break;
                    case "Shift":
                        if (tokens[1] == "left")
                        {
                            count = int.Parse(tokens[2]);
                            ListOprationShiftLeft(numbers, count);
                        }
                        else
                        {
                            count = int.Parse(tokens[2]);
                            ListOperationShiftRight(numbers, count);
                        }
                        break;

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void ListOperationAdd(List<int> numbers, int element)
        {
            numbers.Add(element);
        }

        private static void ListOperationInsert(List<int> numbers, int element, int index)
        {
            if (index > numbers.Count - 1 || index < 0)
            {
                Console.WriteLine($"Invalid index");
            }
            else
            {
               numbers.Insert(index, element);
            }
        }

        private static void ListOperationRemove(List<int> numbers, int index)
        {
            if (index > numbers.Count - 1 || index < 0)
            {
                Console.WriteLine($"Invalid index");
            }
            else
            {
                numbers.RemoveAt(index);
            }
        }

        private static void ListOprationShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int frontElement= numbers[0]; 
                for (int k = 0; k < numbers.Count - 1; k++)
                {
                    numbers[k] = numbers[k + 1];
                }
                numbers[numbers.Count - 1] = frontElement;
          
            }
        }

        private static void ListOperationShiftRight(List<int> numbers, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                int backElement = numbers[numbers.Count - 1];
                for (int k = numbers.Count - 1; k > 0; k--)
                {
                    numbers[k] = numbers[k - 1];
                }
                numbers[0] = backElement;
            }
        }
    }
}
