using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double coins = 0;
            double budget = 0;
            string product = "";

            while ((input = Console.ReadLine()) != "Start")
            {
                coins = double.Parse(input);
                if (coins == 2 || coins == 1 || coins == 0.5 || coins == 0.2 || coins == 0.1)
                {
                    budget += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
           
            }
            double prodPrice = 0;
            while ((product = Console.ReadLine()) != "End")
            {
                if (product == "Nuts")
                {
                    prodPrice = 2;
                }
                else if (product == "Water")
                {
                    prodPrice = 0.7;
                }
                else if (product == "Crisps")
                {
                    prodPrice = 1.5;
                }
                else if (product == "Soda")
                {
                    prodPrice = 0.8;
                }
                else if (product == "Coke")
                {
                    prodPrice = 1;
                }
                else
                {
                    Console.WriteLine($"Invalid product");
                    continue;
                }
                if (budget >= prodPrice)
                {
                    budget -= prodPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }

            }
            Console.WriteLine($"Change: {budget:f2}");
        }
    }
}