using System;

namespace From_Left_to_the_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int index = 0;
              
            while (true)
            {  
                    string leftString = string.Empty;
                    string rightString = string.Empty;
                   int sumOfAllDigitsRightNumber = 0;
                   int sumOfAllDigitsLeftNumber = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    char ch = input[i];
                    if (ch != '-' && ch != ' ')
                    {
                        sumOfAllDigitsLeftNumber += int.Parse(input[i].ToString());
                    }
                    if (ch != ' ')
                    {
                        leftString += ch;
                    }
                    else
                    {
                        index = i;
                        break;
                    }
                }
                for (int j = index + 1; j < input.Length; j++)
                {
                    char ch2 = input[j];
                    if (ch2 != '-')
                    {
                        sumOfAllDigitsRightNumber += int.Parse(input[j].ToString());
                    }
                    rightString += ch2;
                }
                long leftNumber = long.Parse(leftString);
                long rightNumber = long.Parse(rightString);

                if (leftNumber > rightNumber)
                {
                    Console.WriteLine(sumOfAllDigitsLeftNumber);
                }
                else
                {
                    Console.WriteLine(sumOfAllDigitsRightNumber);
                }

                lines--;
                if (lines == 0) break;

                input = Console.ReadLine();
            }
 
        }
    }
    
}
