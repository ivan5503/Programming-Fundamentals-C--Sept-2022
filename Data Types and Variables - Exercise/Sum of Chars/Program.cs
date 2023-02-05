using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= nLines; i++)
            {
                char currChar = char.Parse(Console.ReadLine());
                sum += (int)currChar;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
