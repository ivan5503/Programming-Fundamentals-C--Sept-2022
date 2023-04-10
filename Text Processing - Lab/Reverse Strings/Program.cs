using System;
using System.Linq;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
           
            while ((input = Console.ReadLine()) != "end")
            {
                string text = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    char currChar = input[i];
                    text += currChar;
                }
                Console.WriteLine($"{input} = {text}");


            }
        }
    }
}
