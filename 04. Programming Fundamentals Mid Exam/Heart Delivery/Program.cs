using System;
using System.Collections.Generic;
using System.Linq;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine()
               .Split("@",StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int houseIndex = 0;
            int valentineDaysCounter = 0;

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] command = input.Split();
                int jumpIndex = int.Parse(command[1]);
                houseIndex += jumpIndex;

                if (houseIndex > neighborhood.Length - 1)
                {
                    houseIndex = 0;
                }
                if (neighborhood[houseIndex] == 0)
                {
                    Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
                }
                else if (neighborhood[houseIndex] != 0)
                {
                    neighborhood[houseIndex] -= 2;
                    if (neighborhood[houseIndex] == 0)
                    {
                        Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                        valentineDaysCounter++;
                    }
                }
            }
            Console.WriteLine($"Cupid's last position was {houseIndex}.");
            if (neighborhood.Sum() == 0)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Length - valentineDaysCounter} places.");
            }

        }
    }
}
