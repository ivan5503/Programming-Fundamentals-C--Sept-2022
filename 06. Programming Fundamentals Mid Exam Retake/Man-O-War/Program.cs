using System;
using System.Linq;

namespace Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShipStatus = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] warshipStatus = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int healthCapacity = int.Parse(Console.ReadLine());

            string input = string.Empty; 
            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] command = input.Split(" ");
                Action(pirateShipStatus, warshipStatus, healthCapacity, command);

                if (pirateShipStatus[0] == 0 || warshipStatus[0] == 0) return;
            }
            int pirateShipSum = pirateShipStatus.Sum();
            int warshipSum = warshipStatus.Sum();
            Console.WriteLine($"Pirate ship status: {pirateShipSum}");
            Console.WriteLine($"Warship status: {warshipSum}");

        }

        private static void Action(int[] pirateShipStatus, int[] warshipStatus, int healthCapacity, string[] command)
        {
            switch (command[0])
            {
                case "Fire": Fire(command, warshipStatus, pirateShipStatus); break;
                case "Defend": Defend(command, warshipStatus, pirateShipStatus); break;
                case "Repair": Repair(command, warshipStatus, pirateShipStatus, healthCapacity); break;
                case "Status":  Status(command, warshipStatus, pirateShipStatus, healthCapacity); break;
                    
            }
        }

        private static void Defend(string[] command, int[] warshipStatus, int[] pirateShipStatus)
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);
            int damage = int.Parse(command[3]);

            if (startIndex >= 0 && endIndex < pirateShipStatus.Length)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    if (pirateShipStatus[i] - damage <= 0)
                    {
                        Console.WriteLine("You lost! The pirate ship has sunken.");
                        pirateShipStatus[0] = 0;
                        return;
                    }
                    pirateShipStatus[i] -= damage;
                }
            }
        }

        private static void Fire(string[] command, int[] warshipStatus, int[] pirateShipStatus)
        {
            int index = int.Parse(command[1]);
            int damage = int.Parse(command[2]);

            if (index >= 0 && index < warshipStatus.Length)
            {
                if (warshipStatus[index] - damage <= 0)
                {
                    Console.WriteLine("You won! The enemy ship has sunken.");
                    warshipStatus[0] = 0;
                    return;
                }
                warshipStatus[index] -= damage;
            }
        }

        private static void Status(string[] command, int[] warshipStatus, int[] pirateShipStatus, int healthCapacity)
        {
            int count = 0;
            double twentyPercentFromHealthCapacity = healthCapacity * 20 / 100;
            foreach(var currentHealthShipSection in pirateShipStatus)
            {
                if (currentHealthShipSection < twentyPercentFromHealthCapacity)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} sections need repair.");
        }

        private static void Repair(string[] command, int[] warshipStatus, int[] pirateShipStatus, int healthCapacity)
        {
            int index = int.Parse(command[1]);
            int health = int.Parse(command[2]);

            if (index >= 0 && index < pirateShipStatus.Length)
            {
                if (pirateShipStatus[index] + health > healthCapacity)
                {
                    pirateShipStatus[index] = healthCapacity;
                }
                else
                {
                    pirateShipStatus[index] += health;
                }
            }
        }
    }
}
