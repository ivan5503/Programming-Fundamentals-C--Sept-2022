using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char ch = input[i];
                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }
}
