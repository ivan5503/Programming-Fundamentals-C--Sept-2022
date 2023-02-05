using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int topInteger = 0;
            int isBigger = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                topInteger = numbers[i];
                for (int j = 0; j < (numbers.Length - 1) - i; j++)
                {
                    if (topInteger > numbers[j + 1 + i])
                    {
                        isBigger++;
                    }
                    else
                    {
                        break;
                    }
                    if ((numbers.Length - 1) - i == isBigger)
                    {
                        Console.Write(topInteger + " ");
                           
                    }
    
                    
                }
                isBigger = 0;
            }
            Console.Write(topInteger + " ");
            Console.WriteLine();
        }
    }
}
