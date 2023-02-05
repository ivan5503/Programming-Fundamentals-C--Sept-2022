using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfString = Console.ReadLine().Split().ToList();
            string command = string.Empty;

            while (command != "3:1")
            {
                command = Console.ReadLine();
                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "merge":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        Merge(listOfString, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(tokens[1]);
                        int partitions = int.Parse(tokens[2]);
                        Divide(listOfString, index, partitions);
                        break;



                     
                }
            }
            Console.WriteLine(string.Join(" ", listOfString));

        }

        private static void Divide(List<string> listOfString, int index, int partitions)
        {
            var dividedList = new List<string>();
            string word = listOfString[index];
            listOfString.RemoveAt(index);
            int parts = word.Length / partitions;
            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    dividedList.Add(word.Substring(i * parts));
                }
                else
                {
                    dividedList.Add(word.Substring(i * parts, parts));
                }

            }
            listOfString.InsertRange(index, dividedList);
        }

        private static void Merge(List<string> listOfString, int startIndex, int endIndex)
        {
            string concatedString = string.Empty;

           if (endIndex > listOfString.Count - 1 || endIndex < 0)
           {
                endIndex = listOfString.Count - 1;
           }
           if (startIndex < 0 || startIndex > listOfString.Count - 1)
           {
                startIndex = 0;
           }
            for (int i = startIndex; i <= endIndex; i++)
            {
                concatedString += listOfString[i];
            }
            listOfString.RemoveRange(startIndex,endIndex - startIndex + 1);
            listOfString.Insert(startIndex, concatedString);

        }
    }
}
