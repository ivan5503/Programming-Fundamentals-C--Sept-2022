using System;
using System.Collections.Generic;
using System.Linq;

namespace Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            double savings = double.Parse(Console.ReadLine());

            List<int> initialQualityDrumSet = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> currentQualityDrumSet = new List<int>();
            
            for (int j = 0; j < initialQualityDrumSet.Count; j++)
            {
                currentQualityDrumSet.Add(initialQualityDrumSet[j]);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int currentHitPower = int.Parse(input);

                for (int i = 0; i < initialQualityDrumSet.Count; i++)
                {
                    currentQualityDrumSet[i] -= currentHitPower;

                    if (currentQualityDrumSet[i] <= 0)
                    {
                        currentQualityDrumSet[i] = 0;

                        int initialDrumQuality = initialQualityDrumSet[i];

                        int priceForNewDrum = initialDrumQuality * 3;

                        savings -= priceForNewDrum; 

                        if (savings <= 0)
                        {
                            savings += priceForNewDrum;
                            initialQualityDrumSet.RemoveAt(i);
                            currentQualityDrumSet.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            currentQualityDrumSet[i] = initialDrumQuality;
                        }
                      
                    }
                  
                }

            }
            Console.WriteLine(string.Join(" ", currentQualityDrumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
