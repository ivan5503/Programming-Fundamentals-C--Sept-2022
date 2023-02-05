using System;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            decimal number = 0;
            decimal sum = 0; 

            for (int i = 1; i <= input; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine("{0}",sum);
        }
    }
}
