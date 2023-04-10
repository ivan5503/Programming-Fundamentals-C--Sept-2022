using System;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
           int nLines = int.Parse(Console.ReadLine());

            string input = string.Empty;
            bool isOpened = false;
            bool isBalanced = true;

            for (int i = 1; i <= nLines; i++)
            {
                input = Console.ReadLine();

                if (input == "(")
                {
                    if (!isOpened)
                    {
                        isOpened = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
                else if (input == ")")
                {
                    if (isOpened)
                    {
                        isOpened = false;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }

            }
            if (isBalanced && !isOpened)
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
