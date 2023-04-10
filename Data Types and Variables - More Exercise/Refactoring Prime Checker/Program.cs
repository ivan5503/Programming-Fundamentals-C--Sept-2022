using System;

namespace Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 2; num <= n; num++)
            {
                bool isNumPrime = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isNumPrime = false;
                        break;
                    }
                }
                if (isNumPrime)
                {
                    Console.WriteLine($"{num} -> true");
                }
                else
                {
                    Console.WriteLine($"{num} -> false");
                }

            }
        }
    }
}
