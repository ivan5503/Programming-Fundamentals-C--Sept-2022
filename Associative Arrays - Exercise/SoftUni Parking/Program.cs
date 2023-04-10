using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userNames = new Dictionary<string, string>();

            int lines = int.Parse(Console.ReadLine());

            string input = string.Empty;

            for (int i = 1; i <= lines; i++)
            {
                input = Console.ReadLine();
                string[] command = input.Split();
                string type = command[0];
                string userName = command[1];

                if (type == "register")
                {
                    string licensePlate = command[2];
                    if (!userNames.ContainsKey(userName))
                    {
                        userNames[userName] = licensePlate;
                        Console.WriteLine($"{userName} registered {licensePlate} successfully");
                       
                    }
                    else if (userNames.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else if (type == "unregister")
                {
                    if (!userNames.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        userNames.Remove(userName);
                    }
                }
            }
            foreach (var user in userNames)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
