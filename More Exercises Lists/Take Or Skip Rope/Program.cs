using System;
using System.Collections.Generic;

namespace Take_Or_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            List<int> numbersList = new List<int>();
            List<string> nonNumbersList = new List<string>();

            foreach (var ch in encryptedMessage)
            {
                if (char.IsDigit(ch))
                {
                    int currDigit = int.Parse(ch.ToString());
                    numbersList.Add(currDigit);
                }
                else
                {
                    nonNumbersList.Add(ch.ToString());
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }

            string decryptedMessage = string.Empty;

            for (int j = 0; j < skipList.Count; j++)
            {
                int skipElements = skipList[j];
                int takeElements = takeList[j];


                if (takeElements > nonNumbersList.Count)
                {
                    takeElements = nonNumbersList.Count;
                }

                int counter = takeElements;

                for (int i = 0; i < nonNumbersList.Count; i++)
                {
                    if (counter == 0)
                    {
                        break;
                    }
                    counter--;

                    decryptedMessage += nonNumbersList[i];
                }

                nonNumbersList.RemoveRange(0, takeElements);

                if (skipElements > nonNumbersList.Count)
                {
                    skipElements = nonNumbersList.Count;
                }

                nonNumbersList.RemoveRange(0, skipElements);
                

            }
            Console.WriteLine(decryptedMessage);

        }
 
    }
 
}
