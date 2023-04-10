using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charsOccurrances = new Dictionary<char, int>();

            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var word in words)
            {
                foreach (var currChar in word)
                {
                    if (!charsOccurrances.ContainsKey(currChar))
                    {
                        charsOccurrances.Add(currChar, 0);
                    }
                    charsOccurrances[currChar] += 1;

                }
            }
            foreach (var ch in charsOccurrances)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}
