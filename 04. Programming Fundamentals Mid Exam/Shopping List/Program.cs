using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> itemList = Console.ReadLine().Split('!').ToList();
            string newItem = string.Empty;
            string oldItem = string.Empty;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "Urgent":
                        newItem = tokens[1];
                        Add(itemList, newItem);
                        break;
                    case "Unnecessary":
                        newItem = tokens[1];
                        Remove(itemList, newItem);
                        break;
                    case "Correct":
                        oldItem = tokens[1];
                        newItem = tokens[2];
                        Correct(itemList, newItem, oldItem);
                        break;
                    case "Rearrange":
                        newItem = tokens[1];
                        Rearrange(itemList, newItem);
                        break;




                }


            }
            Console.WriteLine(string.Join(", ", itemList));
        }

        private static void Rearrange(List<string> itemList, string newItem)
        {
            if (itemList.Contains(newItem))
            {
                itemList.Remove(newItem);
                itemList.Add(newItem);

            }
        }

        private static void Correct(List<string> itemList, string newItem, string oldItem)
        {
            if (itemList.Contains(oldItem))
            {
                int index = itemList.IndexOf(oldItem);
                itemList.Insert(index, newItem);
                itemList.Remove(oldItem);
            }
        }

        private static void Remove(List<string> itemList, string newItem)
        {
            if (itemList.Contains(newItem))
            {
                itemList.Remove(newItem);
            }
        }

        private static void Add(List<string> itemList, string newItem)
        {
            if (!itemList.Contains(newItem))
            {
                itemList.Insert(0, newItem);
            }
        }
    }
}
