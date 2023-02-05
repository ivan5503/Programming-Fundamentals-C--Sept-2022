using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int input = int.Parse(Console.ReadLine());
            int multiplier = input;

            if (multiplier > 10)
            {
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
            }
            for (int i = input; i <= 10; i++)
            {
                if (multiplier > 10)
                {

                }
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
                multiplier++;
            }
        }
    }
}
