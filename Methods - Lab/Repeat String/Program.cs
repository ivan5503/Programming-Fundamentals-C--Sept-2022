using System;

namespace Repeat_String1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatTimes = int.Parse(Console.ReadLine());

            string result = GetANewString(input, repeatTimes);
            Console.WriteLine(result);
        }

        static string GetANewString(string input, int repeatTimes)
        {
            string result = string.Empty;
            for (int i = 1; i <= repeatTimes; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
