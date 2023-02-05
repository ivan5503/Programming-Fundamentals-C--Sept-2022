using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double sum = 0;

            switch (product)
            {
                case "coffee":
                    Coffee(1.50, quantity,sum);
                    break;
                case "water":
                    Water(1.00, quantity,sum);
                    break;
                case "coke":
                    Coke(1.40, quantity,sum);
                    break;
                case "snacks":
                    Snacks(2.00, quantity,sum);
                    break;
                   
            }
        }
        static void Coffee(double price, int quantity, double sum)
        {
            sum = price * quantity;
            Console.WriteLine($"{sum:f2}");
        }

        static void Water(double price, int quantity, double sum)
        {
            sum = price * quantity;
            Console.WriteLine($"{sum:f2}");
        }

        static void Coke(double price, int quantity, double sum)
        {
            sum = price * quantity;
            Console.WriteLine($"{sum:f2}");
        }

        static void Snacks(double price, int quantity,double sum)
        {
            sum = price * quantity;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
