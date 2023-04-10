using System;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysOfPlunder = int.Parse(Console.ReadLine());
            double plunderForDay = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;
            
            for (int i = 1; i <= daysOfPlunder; i++)
            {
                totalPlunder += plunderForDay;
                if (i % 3 == 0)
                {
                    totalPlunder += plunderForDay * 50 / 100;
                }
                if (i % 5 == 0)
                {
                    totalPlunder -= totalPlunder * 30 / 100;
                }
            }
            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage = (totalPlunder * 100) / expectedPlunder;

                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }


            
            
        }
    }
}
