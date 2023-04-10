using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string nameGame = string.Empty;
            double price = 0;
            double totalSpent = 0;

            while ((nameGame = Console.ReadLine()) != "Game Time")
            {
                
                if (nameGame == "OutFall 4")
                {
                    price = 39.99;
                    balance -= price;
                }
                else if (nameGame == "CS: OG")
                {
                    price = 15.99;
                    balance -= price;
                }
                else if (nameGame == "Zplinter Zell")
                {
                    price = 19.99;
                    balance -= price;
                }
                else if (nameGame == "Honored 2")
                {
                    price = 59.99;
                    balance -= price;
                }
                else if (nameGame == "RoverWatch")
                {
                    price = 29.99;
                    balance -= price;
                }
                else if (nameGame == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                    balance -= price;
                }
                else
                {
                    Console.WriteLine("Not Found");
                     continue;
                }
                if (balance < 0)
                {
                    Console.WriteLine("Too Expensive");
                    balance += price;
                    continue;
                }
                totalSpent += price;
                if (balance >= 0)
                {
                    Console.WriteLine($"Bought {nameGame}");
                }
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
           
            }
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
        }
    }
}
