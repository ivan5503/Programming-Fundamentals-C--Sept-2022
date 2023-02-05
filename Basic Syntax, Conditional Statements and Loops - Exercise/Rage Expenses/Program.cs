using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrashCounter = 0;
            int mouseTrashCounter = 0;
            int keyboardTrashCounter = 0;
            int displayTrashCounter = 0;
            for (double i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetTrashCounter++;
                }
                if (i % 3 == 0)
                {
                      mouseTrashCounter++;
                    if (mouseTrashCounter % 2 == 0)
                    {
                        keyboardTrashCounter++;
                        if (keyboardTrashCounter % 2 == 0)
                        {
                            displayTrashCounter++;
                        }
                    }
                    

                    
                }
               

            }

            double sumForEquipment = headsetTrashCounter * headsetPrice + mouseTrashCounter * mousePrice + keyboardTrashCounter * keyboardPrice + displayTrashCounter * displayPrice;

            Console.WriteLine($"Rage expenses: {sumForEquipment:f2} lv.");
        }
    }
}
