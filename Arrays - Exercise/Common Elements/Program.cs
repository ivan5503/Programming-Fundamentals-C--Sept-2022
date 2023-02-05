using System;
using System.Collections.Generic;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secondArr = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string commonElements = string.Empty;
            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (secondArr[i] == firstArr[j])
                    {
                        commonElements += firstArr[j];
                        Console.Write(commonElements + " ");
                        commonElements = string.Empty;

                    }
                }
            }
            Console.WriteLine();
        }
    }
}
