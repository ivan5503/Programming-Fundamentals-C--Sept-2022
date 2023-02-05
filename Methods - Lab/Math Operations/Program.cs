using System;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());

            double result = Calculation(first, @operator, second);
            Console.WriteLine(result);
        }

        static double Calculation(int first, string @operator, int second)
        {
            double result = 0;

            switch (@operator)
            {
                case "*":
                   result = first * second;
                    break;
                case "/":
                    result = first / second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "+":
                    result = first + second;
                    break;
            }
            return result;
        }
    }
}
