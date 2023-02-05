using System;

namespace Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char firstChar = ' ';
            char secondChar = ' ';
            char thirdChar = ' ';


            for (int i = 1; i<= 3; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());

                if (i == 1)
                {
                    firstChar = currentChar;
                }
                else if (i == 2)
                {
                    secondChar = currentChar;
                }
                else
                {
                    thirdChar = currentChar;
                }
                
            }
            Console.WriteLine("{0} {1} {2}", thirdChar, secondChar, firstChar);
        }
    }
}
