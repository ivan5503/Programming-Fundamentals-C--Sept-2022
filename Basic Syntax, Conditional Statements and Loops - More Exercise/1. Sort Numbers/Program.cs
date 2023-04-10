using System;


namespace _1._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double maxNumber = double.MinValue;
            double minNumber = double.MaxValue;

            double currentNumber = 0;
            double sum = 0;

            for (int j = 1; j <= 3; j++)
            {
                currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
                sum += currentNumber;
            }
            Console.WriteLine(maxNumber);
            Console.WriteLine($"{sum - (maxNumber + minNumber)}");
            Console.WriteLine(minNumber);

        }
    }
}
