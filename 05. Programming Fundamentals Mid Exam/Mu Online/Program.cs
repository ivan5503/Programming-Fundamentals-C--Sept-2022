using System;
using System.Linq;

namespace Mu_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dungeonRooms = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int[] initialHealthAndBitcoins = new int[] { 100, 0 };
            int roomNumber = 0;
            for (int i = 0; i < dungeonRooms.Length; i++)
            {
                roomNumber = i;
                string[] room = dungeonRooms[i].Split(" ");

                initialHealthAndBitcoins = Command(room, initialHealthAndBitcoins, roomNumber);
                if (initialHealthAndBitcoins[0] <= 0)
                {
                    return;
                }

            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {initialHealthAndBitcoins[1]}");
            Console.WriteLine($"Health: {initialHealthAndBitcoins[0]}");
        }

        private static int[] Command(string[] room, int[] initialHealthAndBitcoins,int roomNumber)
        {
            switch (room[0])
            {
                case "potion": initialHealthAndBitcoins = Potion(room, initialHealthAndBitcoins);break;
                case "chest": initialHealthAndBitcoins = Chest(room, initialHealthAndBitcoins);break;
                default: initialHealthAndBitcoins = MonsterAttack(room, initialHealthAndBitcoins,roomNumber);break;
            }
            return initialHealthAndBitcoins;
        }

        private static int[] Chest(string[] room, int[] initialHealthAndBitcoins)
        {
            int foundedBitcoins = int.Parse(room[1]);
            initialHealthAndBitcoins[1] += foundedBitcoins;
            Console.WriteLine($"You found {foundedBitcoins} bitcoins.");

            return initialHealthAndBitcoins;
        }

        private static int[] MonsterAttack(string[] room, int[] initialHealthAndBitcoins, int roomNumber)
        {
            string monsterName = room[0];
            int attackPower = int.Parse(room[1]);
            if (initialHealthAndBitcoins[0] - attackPower > 0)
            {
                Console.WriteLine($"You slayed {monsterName}.");
                initialHealthAndBitcoins[0] -= attackPower;
            }
            else
            {
                initialHealthAndBitcoins[0] -= attackPower;
                Console.WriteLine($"You died! Killed by {monsterName}.");
                Console.WriteLine($"Best room: {roomNumber + 1}");
                
            }
            return initialHealthAndBitcoins;
        }

        private static int[] Potion(string[] room, int[] initialHealthAndBitcoins)
        {
            string potion = room[0];
            int powerOfPotion = int.Parse(room[1]);
            if (initialHealthAndBitcoins[0] + powerOfPotion > 100)
            {
                powerOfPotion =  100 - initialHealthAndBitcoins[0];
                Console.WriteLine($"You healed for {powerOfPotion} hp.");
                Console.WriteLine($"Current health: {initialHealthAndBitcoins[0] = 100} hp.");
            }
            else
            {
                initialHealthAndBitcoins[0] += powerOfPotion;
                Console.WriteLine($"You healed for {powerOfPotion} hp.");
                Console.WriteLine($"Current health: {initialHealthAndBitcoins[0]} hp.");
            }
            return initialHealthAndBitcoins;
            
        }
    }
}
