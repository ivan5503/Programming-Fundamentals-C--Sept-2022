using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            int sequence = int.Parse(Console.ReadLine());
            int[] dna = new int[sequence];

            string input = Console.ReadLine();
            int sample = 0;
            int counter = 0;
            int dnaSequence = 0;
            int dnaSum = 0;
            int dnaStartIndex = 0;
            int dnaEndIndex = 0;
            while (input != "Clone them!") 
            {
                bool isCurrDnaBetter = false;
                sample++;

                int currMaxSequence = 0;
                int currDnaSum = 0;
                int currEndIndex = 0;
                int currStartIndex = 0;
                int[] currDna = input.Split("!",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int i = 0; i < currDna.Length; i++)
                {
                    if (currDna[i] == 1)
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 0;
                        continue;
                    }
                    if (counter > currMaxSequence)
                    {
                        currMaxSequence = counter;
                        currEndIndex = i;
                    }
                }
                currStartIndex = currEndIndex - currMaxSequence + 1;
                currDnaSum = currDna.Sum();

                if (currMaxSequence > dnaSequence)
                {
                    isCurrDnaBetter = true;
                }
                else if (currMaxSequence == dnaSequence)
                {
                    if (currStartIndex < dnaStartIndex)
                    {
                        isCurrDnaBetter = true;
                    }
                    else if (currStartIndex == dnaStartIndex)
                    {
                        if (currDnaSum > dnaSum)
                        {
                            isCurrDnaBetter = true;
                        }
                    }
                }

                if (isCurrDnaBetter)
                {
                    dna = currDna;
                    dnaSequence = currMaxSequence;
                    dnaSum = currDnaSum;
                    dnaStartIndex = currStartIndex;
                    dnaEndIndex = currEndIndex;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"Best DNA sample {sample} with sum: {dnaSum}.");
            Console.WriteLine(string.Join(" ", dna));
            
        }
    }
}
