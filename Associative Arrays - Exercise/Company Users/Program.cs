using System;
using System.Collections.Generic;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = command[0];
                string employeeId = command[1];

                if (!dictionary.ContainsKey(companyName))
                {
                    dictionary[companyName] = new List<string>();
                    dictionary[companyName].Add(employeeId);
                }
                if (!dictionary[companyName].Contains(employeeId))
                {
                    dictionary[companyName].Add(employeeId);
                }
                  
            }
            foreach (var userInfo in dictionary)
            {
                string name = userInfo.Key;
                List<string> idNumbers = userInfo.Value;
                Console.WriteLine(name);
                
                foreach (var idNum in idNumbers)
                {
                    Console.WriteLine($"-- {idNum}");
                }
            }
        }
    }
}
