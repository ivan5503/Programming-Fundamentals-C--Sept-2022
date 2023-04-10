using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            int[] numbersOfFibonacci = new int[nLines];

            for (int i = 0; i < nLines; i++)
            {
                if (i == 0 || i == 1)
                {
                    numbersOfFibonacci[i] = 1;
                }
                else
                {
                    numbersOfFibonacci[i] = numbersOfFibonacci[i - 2] + numbersOfFibonacci[i - 1];
                }
                 
            }
            Console.WriteLine($"{numbersOfFibonacci[numbersOfFibonacci.Length - 1]}");
        }
    }
}
