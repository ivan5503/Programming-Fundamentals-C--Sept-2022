using System;

namespace Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = " ";
            double partsPrices = 0;
            double priceWithoutTaxes = 0;
            double totalPrice = 0;
            double taxes = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "special")
                {
                    taxes = priceWithoutTaxes * 20 / 100;
                    totalPrice = taxes + priceWithoutTaxes;
                    totalPrice = totalPrice - (totalPrice * 10 / 100);
                    break;
                }
                else if (input == "regular")
                {
                    taxes = priceWithoutTaxes * 20 / 100;
                    totalPrice = taxes + priceWithoutTaxes;
                    break;
                }
                partsPrices = double.Parse(input);
                if (partsPrices < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                priceWithoutTaxes += partsPrices;


            }
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
