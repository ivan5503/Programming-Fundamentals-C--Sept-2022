using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesAndQuantities = new Dictionary<string, int>();

            string resource = string.Empty;
            int quantity = 0;

            while ((resource = Console.ReadLine()) != "stop")
            {
                quantity = int.Parse(Console.ReadLine());

                if (!resourcesAndQuantities.ContainsKey(resource))
                {
                    resourcesAndQuantities.Add(resource, 0);
                }
                resourcesAndQuantities[resource] += quantity;
            }

            foreach (var element in resourcesAndQuantities)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
