using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            


            switch (input)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    int resultInt = GetMaxInteger(first, second);
                    Console.WriteLine(resultInt);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string resultString = GetMaxString(firstString, secondString);
                    Console.WriteLine(resultString);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char resultChar = GetMaxChar(firstChar, secondChar);
                    Console.WriteLine(resultChar);
                    break;
            }
        }

        static char GetMaxChar(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }
        static int GetMaxInteger(int first,int second)
        {
            int resultInt = first.CompareTo(second);
            if (resultInt > 0)
            {
                return first;
            }
            return second;
        }
        static string GetMaxString(string first,string second)
        {
            int resultString = first.CompareTo(second);
            if (resultString > 0)
            {
                return first;
            }
            return second;

        }
           
    }
}
