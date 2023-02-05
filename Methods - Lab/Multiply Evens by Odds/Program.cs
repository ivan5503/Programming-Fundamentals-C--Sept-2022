using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            int result = 0;
            return result = evenSum * oddSum;
        }
        

        static int GetSumOfOddDigits(int number)
        {
            number = Math.Abs(number);
            int oddSum = 0;
            int j = number;
            while (j > 0)
            {
                number = j % 10;
                if (number % 2 != 0)
                {
                    oddSum += number;
                }
                j = j / 10;
            }
            return oddSum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            number = Math.Abs(number);
            int evenSum = 0;
            int i = number;
            while (i > 0)
            {
                number = i % 10;
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                i = i / 10;
            }
            return evenSum;
        }
    }
}
