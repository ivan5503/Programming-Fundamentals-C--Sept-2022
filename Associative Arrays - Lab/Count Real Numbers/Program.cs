using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> occurrancesByNumber = new SortedDictionary<int, int>();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var number in numbers)
            {
                if (occurrancesByNumber.ContainsKey(number))
                {
                    int currentOccurrance = occurrancesByNumber[number];
                    currentOccurrance += 1;
                    occurrancesByNumber[number] = currentOccurrance;
                }
                else
                {
                    occurrancesByNumber.Add(number,1);
                }
            }
            foreach (var occurranceByNumber in occurrancesByNumber)
            {
                Console.WriteLine($"{occurranceByNumber.Key} -> {occurranceByNumber.Value}");
            }
        }
    }
}
