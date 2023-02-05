using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> copyOfTheNumbers = new List<int>();
            copyOfTheNumbers.AddRange(numbers);
            
            string command = string.Empty;
            int counter = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                if (action == "Contains")
                {
                    int containsNum = int.Parse(tokens[1]);
                    if (numbers.Contains(containsNum))
                    {
                        Console.WriteLine("Yes");  
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }


                }
                else if (action == "PrintEven")
                {
                   foreach (var number in numbers)
                   {
                        if (number % 2 == 0)
                        {
                            Console.Write(number + " ");
                        }
                   }
                    Console.WriteLine();
                }
                else if (action == "PrintOdd")
                {
                   
                    foreach (var number in numbers)
                    {
                        if (number % 2 != 0)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (action == "GetSum")
                {
                    int sum = 0;
                    foreach (var number in numbers)
                    {
                        sum += number;
                    }
                    Console.WriteLine(sum);

                }
                else if (action == "Filter")
                {
                    counter++;
                    string condition = (tokens[1]);
                    int number = int.Parse(tokens[2]);
                    
                    if (condition == "<")
                    {
                        copyOfTheNumbers.RemoveAll(copyOfTheNumbers => copyOfTheNumbers > number);
                    }
                    else if (condition == ">")
                    {
                        copyOfTheNumbers.RemoveAll(copyOfTheNumbers => copyOfTheNumbers < number);
                    }
                    else if (condition == ">=")
                    {
                        copyOfTheNumbers.RemoveAll(copyOfTheNumbers => copyOfTheNumbers <= number);
                    }
                    else
                    {
                        copyOfTheNumbers.RemoveAll(copyOfTheNumbers => copyOfTheNumbers >= number);
                    }
                    Console.WriteLine(string.Join(" ", copyOfTheNumbers));
                    copyOfTheNumbers.RemoveAll(copyOfTheNumbers => copyOfTheNumbers >= 0);
                    copyOfTheNumbers.AddRange(numbers);
                }
                    
            }
            

        }
    }
}
