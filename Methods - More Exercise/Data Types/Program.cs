using System;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            switch (input)
            {
                case "int":
                    int inputInt = int.Parse(Console.ReadLine());
                    PrintResult(inputInt);
                    break;
                case "real":
                    double inputDouble = double.Parse(Console.ReadLine());
                    PrintResult(inputDouble);
                    break;
                case "string":
                    string word = Console.ReadLine();
                    Console.WriteLine($"${word}$");
                    break;
            }
        }

        private static void PrintResult(double inputDouble)
        {
            Console.WriteLine($"{inputDouble * 1.5:f2}");
        }

        private static void PrintResult(int inputInt)
        {
            Console.WriteLine($"{inputInt * 2}");
        }
    }
}
