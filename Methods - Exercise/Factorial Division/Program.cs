﻿using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double result1 = Factoriel(firstNum);
            double result2 = Factoriel(secondNum);
            PrintResult(result1, result2);
            

        }
        static void PrintResult(double result1, double result2)
        {

            Console.WriteLine($"{result1 / result2:f2}");
        }
        static double Factoriel(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }
    }
}
