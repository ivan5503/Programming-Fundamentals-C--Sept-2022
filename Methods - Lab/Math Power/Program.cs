using System;
using System.Reflection.Metadata.Ecma335;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = ReturnToTheGivenPower(number, power);
            Console.WriteLine(result);



        }
        static double ReturnToTheGivenPower(double number, int power)
        {
            double result = 0;
            result = Math.Pow(number, power);
            return result;
        }
      
        
    }
}