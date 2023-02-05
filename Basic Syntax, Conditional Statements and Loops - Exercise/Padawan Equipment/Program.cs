using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());           
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceForSingleLightsaber = double.Parse(Console.ReadLine());
            double priceForSingleRobe = double.Parse(Console.ReadLine());
            double priceForSingleBelt = double.Parse(Console.ReadLine());

            double totalNumberOfSabers = Math.Ceiling(countOfStudents * 1.10);
            double numberOfFreeBelts = Math.Floor(countOfStudents / 6.0);

            double finalPriceOfSabers = totalNumberOfSabers * priceForSingleLightsaber; 
            double finalPriceOfBelts = (countOfStudents - numberOfFreeBelts) * priceForSingleBelt;
            double priceForRobes = priceForSingleRobe * countOfStudents;

            double priceForAll = priceForRobes + finalPriceOfBelts + finalPriceOfSabers;

            if (priceForAll <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {priceForAll:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(priceForAll):f2}lv more.");
            }

             
        }
    } 
}
