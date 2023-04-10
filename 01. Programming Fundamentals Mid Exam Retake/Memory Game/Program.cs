using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();
            string indexes = string.Empty;
            int moveCounter = 0;
            int turnsCounter = 0;
            while ((indexes = Console.ReadLine()) != "end")
            {
                string[] tokens = indexes.Split();
                int firstIndex = int.Parse(tokens[0]);
                int secondIndex = int.Parse(tokens[1]);


                moveCounter++;
                if (firstIndex < 0 || firstIndex > list.Count - 1 || secondIndex < 0 || secondIndex > list.Count - 1
                    || firstIndex == secondIndex)
                {
                    string result = ($"-{moveCounter}a");
                    int middle = list.Count / 2;
                    list.Insert(middle, result);
                    list.Insert(middle + 1, result);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }
                else if (list[firstIndex] == list[secondIndex])
                {
                    turnsCounter++;
                    Console.WriteLine($"Congrats! You have found matching elements - {list[firstIndex]}!");
                    int lowerIndex = Math.Min(firstIndex, secondIndex);
                    int biggerIndex = Math.Max(firstIndex, secondIndex);
                    list.RemoveAt(lowerIndex);
                    list.RemoveAt(biggerIndex - 1);

                    if (list.Count == 0)
                    {
                        Console.WriteLine($"You have won in {turnsCounter} turns!");
                        return;
                    }
                }
                else if (list[firstIndex] != list[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }
            }
            Console.WriteLine($"Sorry you lose :(");
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
