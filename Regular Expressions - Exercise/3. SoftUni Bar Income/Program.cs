using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<customer>[A-Z][a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$";
             Regex regex = new Regex(pattern);

            double totalPrice = 0;
            double totalIncome = 0;

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                
                Match match = regex.Match(input);
                if(match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    totalPrice = count * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }
         

            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
