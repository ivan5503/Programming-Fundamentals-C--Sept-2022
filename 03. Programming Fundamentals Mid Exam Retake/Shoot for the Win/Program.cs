using System;
using System.Linq;

namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;
            int shotTargetsCounter = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int indexOfTheCurrentTarget = int.Parse(input);

                if (indexOfTheCurrentTarget < 0 || indexOfTheCurrentTarget > targets.Length - 1) continue;

                int valueOfTheCurrentTarget = 0;
                for (int i = 0; i < targets.Length; i++)
                {
                    if (indexOfTheCurrentTarget == i && targets[i] != -1)
                    {
                        valueOfTheCurrentTarget = targets[i];
                        targets[i] = -1;
                        shotTargetsCounter++;
                    }

                }
                for (int j = 0; j < targets.Length; j++)
                {
                    if (targets[j] > valueOfTheCurrentTarget && targets[j] != -1)
                    {
                        targets[j] -= valueOfTheCurrentTarget;
                    }
                    else if (targets[j] <= valueOfTheCurrentTarget && targets[j] != -1)
                    {
                        targets[j] += valueOfTheCurrentTarget;
                    }
                }
            }

            Console.WriteLine($"Shot targets: {shotTargetsCounter} -> {string.Join(" ", targets)}");
        }
    }
}
