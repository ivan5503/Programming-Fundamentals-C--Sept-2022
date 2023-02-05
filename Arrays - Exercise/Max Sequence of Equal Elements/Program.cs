using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray(); 

            int maxCounter = int.MinValue;
            int counter = 0;
            int startIndex = 0;
            int endIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                   
                    if (currNumber == numbers[j])
                    {
                       counter++;
                       

                    }
                    else
                    {
                        break;
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        startIndex = i;
                        endIndex = j;
                    }
                }
                counter = 0;
               


            } 
            for (int k = startIndex; k <= endIndex; k++)
            {
                Console.Write($"{numbers[k]} ");
            }
            Console.WriteLine();

        }
    }
}
