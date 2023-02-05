using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentDigit = 0;
            int number = 0;
            int currentIndex = 0;
            for (int i = 1; i <= n; i++)
            {
                currentIndex = i;
                number = i;
                while (number != 0)
                {
                    i = number;

                    currentDigit = number % 10;
                    sum += currentDigit;
                    number = i / 10;
                    
                    

                }
                i = currentIndex;
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sum = 0;
            }
            

        }
    }
}
