using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] command = input.Split(" - ");

                items = Action(command, items);
            }
            Console.WriteLine(string.Join(", ", items));
        }

        private static List<string> Action(string[] command, List<string> items)
        {
            switch (command[0])
            {
                case "Collect": items = Collect(command, items);break;
                case "Drop": items = Drop(command, items);break;
                case "Combine Items": items = CombineItems(command, items);break;
                case "Renew": items = Renew(command, items);break;
                default:
                    break;
            }
            return items;
        }

        private static List<string> Renew(string[] command, List<string> items)
        {
            string item = command[1];
            if (items.Contains(item))
            {
                items.Remove(item);
                items.Add(item);
            }
            return items;
        }

        private static List<string> CombineItems(string[] command, List<string> items)
        {
            string[] combineItems = command[1].Split(":");
            string oldItem = combineItems[0];
            string newItem = combineItems[1];

            if (items.Contains(oldItem))
            {
                int index = items.IndexOf(oldItem);
                items.Insert(index + 1, newItem);
            }
            return items;
        }

        private static List<string> Drop(string[] command, List<string> items)
        {
            string item = command[1];

            if (items.Contains(item))
            {
                items.Remove(item);
            }
            return items;
        }

        private static List<string> Collect(string[] command, List<string> items)
        {
            string item = command[1];

            if (!items.Contains(item))
            {
                items.Add(item);
            }
            return items;
            
        }
    }
}
