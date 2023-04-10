using System;

namespace Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "true" || input == "false")
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (input.Length < 2)
                {
                    char ch = input[0];
                    if (char.IsDigit(ch))
                    {
                        Console.WriteLine($"{input} is integer type");
                    }
                    else
                    {
                        Console.WriteLine($"{input} is character type");
                    }
                }
                else
                {
                    bool isInputNumber = true;
                    int counterHyphen = 0;
                    int counterPoint = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        char currentChar = input[i];
                        if (!(char.IsDigit(currentChar) || currentChar == '.' || currentChar == '-'))
                        {
                            Console.WriteLine($"{input} is string type");
                            isInputNumber = false;
                            break;
                        }

                        if (currentChar == '.') counterPoint++;
                        if (currentChar == '-') counterHyphen++;

                    }
                    if (isInputNumber)
                    {
                        if (counterHyphen > 1 || counterPoint > 1 || counterHyphen == 1 && input[0] != '-'
                            || counterPoint == 1 && input[0] == '.' || counterPoint == 1 && input[input.Length - 1] == '.')
                        {
                            Console.WriteLine($"{input} is string type");
                        }
                        else
                        {
                            if (counterPoint == 1)
                            {
                                Console.WriteLine($"{input} is floating point type");
                            }
                            else
                            {
                                Console.WriteLine($"{input} is integer type");
                            }

                        }
                    }

                }

            }
        }
    }

}
