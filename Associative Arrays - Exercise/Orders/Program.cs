using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, double> orders = new Dictionary<string, double>();
            Dictionary<string, int> newOrders = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] command = input.Split();
                string productName = command[0];
                double productPrice = double.Parse(command[1]);
                int quantity = int.Parse(command[2]);

                if (!orders.ContainsKey(productName))
                {
                    orders[productName] = productPrice;
                    newOrders[productName] = quantity;
                }
                else
                {
                    orders.Remove(productName);
                    orders[productName] = productPrice;
                    newOrders[productName] += quantity;
                }

            }
            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders)
                {
                    if (order.Key == newOrder.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {order.Value * newOrder.Value:f2}");
                    }
                }
            }

        }
    }
}
