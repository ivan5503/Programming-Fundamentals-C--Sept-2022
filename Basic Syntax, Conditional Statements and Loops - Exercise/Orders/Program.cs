using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            double pricePerCapsule = 0;
            int daysInMonth = 0;
            int capsulesCount = 0;
            double price = 0;
            double totalSum = 0;
            for (int i = 1; i <= countOfOrders; i++)
            {
                 
                pricePerCapsule = double.Parse(Console.ReadLine());
                daysInMonth = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());
                if (countOfOrders > 1)
                {
                    price = ((daysInMonth * capsulesCount) * pricePerCapsule);
                    totalSum += price;
                    Console.WriteLine($"The price for the coffee is: ${price:f2}");
                    pricePerCapsule = 0;
                    daysInMonth = 0;
                    capsulesCount = 0;

                }
                else
                {
                    price = ((daysInMonth * capsulesCount) * pricePerCapsule);
                    Console.WriteLine($"The price for the coffee is: ${price:f2}");
                    Console.WriteLine($"Total: ${price:f2}");
                    return;
                }
                
                
              
            }
                Console.WriteLine($"Total: ${totalSum:f2}");

        }
    }
}
