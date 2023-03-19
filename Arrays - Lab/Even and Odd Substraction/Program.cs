using System;
using System.Linq;

namespace Even_and_Odd_Substraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;
            int num = 0;
          

            for (int i = 0; i < numbers.Length; i++)
            {
                num = numbers[i];
                if(num % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            int result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}
