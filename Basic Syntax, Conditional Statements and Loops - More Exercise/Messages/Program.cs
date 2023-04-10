using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            string stringNumber = string.Empty;
            string text = string.Empty;
            int mainNumber = 0;
            int numberOfDigits = 0;
            int offset = 0;
            int letterIndex = 0;

            for (int i = 0; i < lines; i++)
            {
                stringNumber = Console.ReadLine();

                mainNumber = int.Parse(stringNumber[0].ToString());
                numberOfDigits = stringNumber.Length;

                if (mainNumber != 8 && mainNumber != 9 && mainNumber != 0)
                {
                    offset = (mainNumber - 2) * 3;
                    letterIndex = offset + numberOfDigits - 1;
                    text += (char)(letterIndex + 97);
                    continue;
                }
                else if (mainNumber == 0)
                {
                    text += " ";
                    continue;
                }
                else
                {
                    offset = (mainNumber - 2) * 3;
                    offset += 1;
                    letterIndex = offset + numberOfDigits - 1;
                    text += (char)(letterIndex + 97);
                }

            }
            Console.WriteLine(text);
        }
    }
}
