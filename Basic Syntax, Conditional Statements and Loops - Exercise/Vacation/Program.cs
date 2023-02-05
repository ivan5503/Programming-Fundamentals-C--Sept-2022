using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (day == "Friday")
            {
                if (group == "Students")
                {
                    price = 8.45;
                    price = price * people;
                    if (people >= 30)
                    {
                        price = price - (price * 15 / 100);
                    }
                     
                }
                else if (group == "Business")
                {
                    price = 10.90;
                    price = price * people;
                    if (people >= 100)
                    {
                        price = price - (10.90 * 10);
                    }
                   
                }
                else if (group == "Regular")
                {
                    price = 15;
                    price = price * people;
                    if (people >= 10 && people <= 20)
                    {
                        price = price - (price * 5 / 100);
                    }
                }
            }
            else if (day == "Saturday")
            {
                if (group == "Students")
                {
                    price = 9.80;
                    price = price * people;
                    if (people >= 30)
                    {
                        price = price - (price * 15 / 100);
                    }
                }
                else if (group == "Business")
                {
                    price = 15.60;
                    price = price * people;
                    if (people >= 100)
                    {
                        price = price - (15.60 * 10);
                    }
                }
                else if (group == "Regular")
                {
                    price = 20;
                    price = price * people;
                    if (people >= 10 && people <= 20)
                    {
                        price = price - (price * 5 / 100);
                    }
                }
            }
            else
            {
                if (group == "Students")
                {
                    price = 10.46;
                    price = price * people;
                    if (people >= 30)
                    {
                        price = price - (price * 15 / 100);
                    }
                }
                else if (group == "Business")
                {
                    price = 16;
                    price = price * people;
                    if (people >= 100)
                    {
                        price = price - (16 * 10);
                    }
                }
                else if (group == "Regular")
                {
                    price = 22.50;
                    price = price * people;
                    if (people >= 10 && people <= 20)
                    {
                        price = price - (price * 5 / 100);
                    }
                }
                
            }
            Console.WriteLine($"Total price: {price:f2}");
            
            
        
        }
    }
}
