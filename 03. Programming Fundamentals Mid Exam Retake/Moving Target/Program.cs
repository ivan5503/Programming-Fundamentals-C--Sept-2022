using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targetsList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
               targetsList =  trackOfMovingTargets(targetsList, command);
            }
            Console.WriteLine(string.Join('|', targetsList));
        }

        static List<int> trackOfMovingTargets(List<int> targetsList, string[] command)
        {
            switch (command[0])
            {
                case "Shoot": targetsList = Shoot(targetsList, command);break;
                case "Add": targetsList = Add(targetsList, command);break;
                case "Strike": targetsList = Strike(targetsList, command);break;
                default:
                    break;
            }
            return targetsList;
        }

        static List<int> Strike(List<int> targetsList, string[] command)
        {
            int index = int.Parse(command[1]);
            int radius = int.Parse(command[2]);
            int startIndex = index - radius;
            int endIndex = index + radius;

            if (startIndex < 0 || endIndex > targetsList.Count - 1)
            {
                Console.WriteLine($"Strike missed!");
                return targetsList;
            }
            for (int i = startIndex; i <= endIndex; i++)
            { 
                targetsList.RemoveAt(startIndex); 
            }
            return targetsList;
        }

        static List<int> Add(List<int> targetsList, string[] command)
        {
            int index = int.Parse(command[1]);
            int insertValue = int.Parse(command[2]);
            
            if (index < 0 || index > targetsList.Count - 1)
            {
                Console.WriteLine($"Invalid placement!");
            }
            else
            {
                targetsList.Insert(index, insertValue);
            }
            return targetsList;
        }

        static List<int> Shoot(List<int> targetsList, string[] command)
        {
            int targetIndex = int.Parse(command[1]);
            int power = int.Parse(command[2]);

            if (targetIndex >= 0 && targetIndex <= targetsList.Count - 1)
            {
                if (targetsList[targetIndex] <= power)
                {
                   targetsList.Remove(targetsList[targetIndex]);
                }
                else
                {
                   targetsList[targetIndex] -= power;
                }    
            }
            return targetsList;
        }
    }
}
