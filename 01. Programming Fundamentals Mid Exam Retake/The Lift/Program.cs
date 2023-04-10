using System;
using System.Linq;

namespace The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int touristsCount = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int wagonCapacity = 4;

            for (int i = 0; i < wagons.Length; i++)
            {
                if (wagons[i] == wagonCapacity)
                {
                    continue;
                }
                else
                {
                    while (wagons[i] != wagonCapacity)
                    {
                        if (touristsCount == 0)
                        {
                            Console.WriteLine("The lift has empty spots!");
                            Console.WriteLine(string.Join(" ", wagons));
                            return;
                        }
                        touristsCount--;
                        wagons[i] += 1;

                    }
                }
            }
            if (touristsCount > 0)
            {
                Console.WriteLine($"There isn't enough space! {touristsCount} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
