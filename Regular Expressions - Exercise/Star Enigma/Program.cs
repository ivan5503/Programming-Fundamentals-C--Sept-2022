using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@(?<name>[A-za-z]+)\d*[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attack>[AD])![^@\-!:>]*->(?<soldierCount>\d+)";

            int lines = int.Parse(Console.ReadLine());
            var attacked = new List<string>();
            var destroyed = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string message = Console.ReadLine();

                int sum = message.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
                string decryptedMessage = string.Empty;

                foreach (var symbol in message)
                {
                    decryptedMessage += (char)(symbol - sum);
                }
                
                Match matches = Regex.Match(decryptedMessage,pattern,RegexOptions.IgnoreCase);

                if (matches.Success)
                {
                    string name = matches.Groups["name"].Value;
                    int population = int.Parse(matches.Groups["population"].Value);
                    char attackType = char.Parse(matches.Groups["attack"].Value);
                    int soldierCount = int.Parse(matches.Groups["soldierCount"].Value);


                    if (attackType == 'A')
                    {
                        attacked.Add(name);
                    }
                    else
                    {
                        destroyed.Add(name);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            attacked.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            destroyed.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
        }
    }
}
