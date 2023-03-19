using System;
using System.Linq;

namespace Equal_Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int currentElementArr1 = 0;
            int currentElementArr2 = 0;
            int sumOfElements = 0;

            for (int index = 0; index < arr1.Length; index++)
            {
                currentElementArr1 = arr1[index];
                currentElementArr2 = arr2[index];

                if (currentElementArr1 == currentElementArr2)
                {
                    sumOfElements += currentElementArr1;
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sumOfElements}");
        }
    }
}
