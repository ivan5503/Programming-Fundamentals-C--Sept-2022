using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> furnitureNames = new List<string>();
            double spendedMoney = 0;
            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>[0-9]+(\.[0-9]+){0,1})!(?<quantity>[0-9]+)(\.[0-9]+){0,1}$";

            string input = string.Empty;
            
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);

                    furnitureNames.Add(furnitureName);
                    spendedMoney += price * quantity;
;               }
               
            }
            Console.WriteLine($"Bought furniture:");
            foreach (var name in furnitureNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Total money spend: {spendedMoney:f2}");
        }
    }
}
