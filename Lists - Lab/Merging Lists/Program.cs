using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();

            int biggerCount = Math.Max(firstList.Count, secondList.Count);
            int smallerCount = (firstList.Count + secondList.Count) - biggerCount;

            for (int i = 0; i < smallerCount; i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }
            if (biggerCount != smallerCount)
            {
                for (int j = smallerCount; j < biggerCount; j++)
                {
                    if (firstList.Count > j)
                    {
                        resultList.Add(firstList[j]);
                    }
                    if (secondList.Count > j)
                    {
                        resultList.Add(secondList[j]);
                    }

                }
            }
            Console.WriteLine(string.Join(" ", resultList));



        }
    }
}
