using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixed_Up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int shorterList = firstList.Count;

            int firstRemainingElement = secondList[0];
            int secondRemainingElement = secondList[1];

            if (shorterList > secondList.Count)
            {
                shorterList = secondList.Count;

                firstRemainingElement = firstList[firstList.Count - 1];
                secondRemainingElement = firstList[firstList.Count - 2];
            }

            int counterFirstList = 0;
            int counterSecondList = 0;

            if (shorterList == secondList.Count)
            {
                counterSecondList = shorterList - 1;
            }
            else
            {
                counterSecondList = shorterList + 1;
            }

            List<int> mixedUpList = new List<int>();

            for (int i = 0; i < shorterList * 2; i++)
            {
                if (i % 2 == 0)
                {
                    mixedUpList.Add(firstList[counterFirstList]);
                    counterFirstList++;
                }
                else
                {
                    mixedUpList.Add(secondList[counterSecondList]);
                    counterSecondList--;
                }
            }

            int startRange = firstRemainingElement;
            int endRange = secondRemainingElement;

            if (firstRemainingElement > secondRemainingElement)
            {
                startRange = secondRemainingElement;
                endRange = firstRemainingElement;
            }

            mixedUpList = mixedUpList.OrderBy(n => n)
                .Where(n => n > startRange && n < endRange).ToList();


            Console.WriteLine(string.Join(" ", mixedUpList));
        }
    }
}
