using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> itemsInitialLoot = Console.ReadLine()
                  .Split("|", StringSplitOptions.RemoveEmptyEntries)
                  .ToList();

            List<string> stolenItems = new List<string>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                string[] command = input.Split(" ");
                itemsInitialLoot = Action(command, itemsInitialLoot, stolenItems);
            }
            if (itemsInitialLoot.Count == 0)
            {
                Console.WriteLine($"Failed treasure hunt.");
            }
            else
            {
                double averageGain = 0;
                foreach (var item in itemsInitialLoot)
                {
                    averageGain += item.Count();
                }
                Console.WriteLine($"Average treasure gain: {averageGain / itemsInitialLoot.Count:f2} pirate credits.");
            }
        }

        private static List<string> Action(string[] command, List<string> itemsInitialLoot, List<string> stolenItems)
        {
            switch (command[0])
            {
                case "Loot": itemsInitialLoot = Loot(command, itemsInitialLoot); break;
                case "Drop": itemsInitialLoot = Drop(command, itemsInitialLoot); break;
                case "Steal": itemsInitialLoot = Steal(command, itemsInitialLoot, stolenItems); break;
                default:
                    break;
            }
            return itemsInitialLoot;
        }

        private static List<string> Steal(string[] command, List<string> itemsInitialLoot, List<string> stolenItems)
        {
            int stealCount = int.Parse(command[1]);

            for (int i = itemsInitialLoot.Count - 1; i >= 0; i--)
            {
                if (stealCount == 0)
                {
                    break;
                }
                stolenItems.Add(itemsInitialLoot[i]);
                itemsInitialLoot.Remove(itemsInitialLoot[i]);
                stealCount--;
            }
            stolenItems.Reverse();
            Console.WriteLine(string.Join(", ", stolenItems));
            stolenItems.Clear();
            return itemsInitialLoot;
        }

        private static List<string> Drop(string[] command, List<string> items)
        {
            int position = int.Parse(command[1]);

            if (position < 0 || position >= items.Count - 1 || items.Count < 2)
            {
                return items;
            }
            else
            {
                items.Add(items[position]);
                items.Remove(items[position]);
                return items;
            }

        }

        private static List<string> Loot(string[] command, List<string> items)
        {
            for (int i = 1; i < command.Length; i++)
            {
                string item = command[i];
                if (!items.Contains(item))
                {
                    items.Insert(0, item);
                }
            }
            return items;
        }
    }
}
