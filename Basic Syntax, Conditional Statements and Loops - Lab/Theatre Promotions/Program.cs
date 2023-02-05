using System;

namespace Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            var priceOfTheTicket = 0;
            if (age >= 0 && age <= 18)
            {
                if (day == "weekday")
                {
                    priceOfTheTicket = 12; 
                }
                else if (day == "weekend")
                {
                    priceOfTheTicket = 15;
                }
                else
                {
                    priceOfTheTicket = 5;
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (day == "weekday")
                {
                    priceOfTheTicket = 18;
                }
                else if (day == "weekend")
                {
                    priceOfTheTicket = 20;
                }
                else
                {
                    priceOfTheTicket = 12;
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (day == "weekday")
                {
                    priceOfTheTicket = 12;
                }
                else if (day == "weekend")
                {
                    priceOfTheTicket = 15;
                }
                else
                {
                    priceOfTheTicket = 10;
                }
            }
            else
            {
                Console.WriteLine("Error!");
                return;
            }
            Console.WriteLine($"{priceOfTheTicket}$");
        }
    }
}
