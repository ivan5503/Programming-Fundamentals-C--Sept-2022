using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                string actions = tokens[0];
                switch (actions)
                {

                    case "Add":
                        int addNum = int.Parse(tokens[1]);
                        numbers.Add(addNum);
                        break;
                    case "Remove":
                        int removeNum = int.Parse(tokens[1]);
                        numbers.Remove(removeNum);
                        break;
                    case "RemoveAt":
                        int removeAtIndexx = int.Parse(tokens[1]);
                        numbers.RemoveAt(removeAtIndexx);
                        break;
                    case "Insert":
                        int element = int.Parse(tokens[1]);
                        int removeAtIndex = int.Parse(tokens[2]);
                        numbers.Insert(removeAtIndex, element);
                        break;
                }



            }
                Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
