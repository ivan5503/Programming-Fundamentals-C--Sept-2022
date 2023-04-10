using System;

namespace Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double num1 = 0.0;
            double num2 = 0.0;
            double difference = 0.0;
            while (true)
            {
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());

                difference = Math.Abs(num1 - num2);

                if (difference < eps)
                {
                    Console.WriteLine("True");
                    return;
                }
                else
                {
                    Console.WriteLine("False");
                    return;
                }

               
            }

        }
    }
}
