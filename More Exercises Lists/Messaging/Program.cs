using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            string textInput = Console.ReadLine();

            string textOutput = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                string currentElement = numbers[i].ToString();

                numbers[i] = 0;

                numbers = CalculateTheSumOfDigitsForEachElement(numbers, currentElement,i);
            }

            int index = 0;

            for (int k = 0; k < numbers.Count; k++)
            {
                if (numbers[k] > textInput.Length)
                {
                    numbers[k] = numbers[k] % textInput.Length;    
                }
                else if (numbers[k] == textInput.Length)
                {
                    index = 0;
                }

                index = numbers[k];

                textOutput += textInput[index];

                textInput = RemoveTheTakenChar(textInput, index);
            }
            Console.WriteLine(textOutput);
        }

        static List<int> CalculateTheSumOfDigitsForEachElement(List<int> numbers, string currentElement, int i)
        {
            for (int j = 0; j < currentElement.Length; j++)
            {
                string str = currentElement[j].ToString();

                numbers[i] += int.Parse(str);
            }
            return numbers;
        }

        static string RemoveTheTakenChar(string textInput, int index)
        {
            string currentText = String.Empty;

            for (int i = 0; i < textInput.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                currentText += textInput[i];
            }
            return currentText;
        }
    }
}
