using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string input = string.Empty;
            int countWonBattles = 0;
            while ((input = Console.ReadLine()) != "End of battle")
            {

                int distanceOfAnEnemy = int.Parse(input);

                if (initialEnergy >= distanceOfAnEnemy)
                {
                    initialEnergy -= distanceOfAnEnemy;
                    countWonBattles++;
                    if (countWonBattles % 3 == 0)
                    {
                        initialEnergy += countWonBattles;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countWonBattles} won battles and {initialEnergy} energy");
                    return;
                }
                
            }
            Console.WriteLine($"Won battles: {countWonBattles}. Energy left: {initialEnergy}");
        }
    }
}
