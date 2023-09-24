using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .ToList();

            int finishLineIndex = numbers.Count / 2;

            double leftRacerTime = 0;

            for (int i = 0; i < finishLineIndex; i++)
            {
                if (numbers[i] == 0)
                {
                    leftRacerTime = leftRacerTime - (leftRacerTime * 20 / 100);
                }
                else
                {
                    leftRacerTime += numbers[i];
                }
                
            }

            double rightRacerTime = 0;

            for (int j = numbers.Count - 1; j >= finishLineIndex + 1; j--)
            {
                if (numbers[j] == 0)
                {
                    rightRacerTime = rightRacerTime - (rightRacerTime * 20 / 100);
                }
                else
                {
                    rightRacerTime += numbers[j];
                }
            }

            if (leftRacerTime < rightRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
            }

        }
    }
}
