using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();
            string name = string.Empty;
            for (int i = 1; i <= input; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();

                if (tokens.Length == 3)
                {
                    name = tokens[0];
                    NameIsGoing(guestList, name);

                }
                else if (tokens.Length == 4)
                {
                    name = tokens[0];
                    NameIsNotGoing(guestList, name);
                }
            }
            foreach (string guest in guestList)
            {
                Console.WriteLine(guest);
            }
            
        }

        private static void NameIsNotGoing(List<string> guestList, string name)
        {
            if (guestList.Contains(name))
            {
                guestList.Remove(name);
            }
            else
            {
                Console.WriteLine($"{name} is not in the list!");
            }
        }

        private static void NameIsGoing(List<string> guestList, string name)
        {
            if (guestList.Contains(name))
            {
                Console.WriteLine($"{name} is already in the list!");
            }
            else
            {
                guestList.Add(name);
            }
        }
    }
}
