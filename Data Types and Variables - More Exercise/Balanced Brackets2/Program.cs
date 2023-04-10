using System;

namespace Balanced_Brackets2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int countOpenedBrackets = 0;
            int countClosedBrackets = 0;

            for (int i = 1; i <= nLines; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    countOpenedBrackets++;

                }
                else if (input == ")")
                {
                    countClosedBrackets++;
                    if (countOpenedBrackets - countClosedBrackets != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            if (countOpenedBrackets == countClosedBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
