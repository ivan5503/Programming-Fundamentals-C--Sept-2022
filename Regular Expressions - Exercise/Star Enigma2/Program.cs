using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Star_Enigma2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            string pattern = @"@(?<name>[A-Za-z]+)([^@\-!:>])*:(?<population>[0-9]+)([^@\-!:>])*!(?<attack>[AD])!([^@\-!:>])*->(?<soldierCount>[0-9]+)";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptedMessage(encryptedMessage);

                Match match = regex.Match(decryptedMessage);
                if (match.Success)
                {
                    string planetName = match.Groups["name"].Value;
                    string attackType = match.Groups["attack"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }
            PrintPLanets(attackedPlanets, "Attacked");
            PrintPLanets(destroyedPlanets, "Destroyed");


        }

        static void PrintPLanets(List<string> planets, string attackType)
        {
            Console.WriteLine($"{attackType} planets: {planets.Count}");
            foreach (string planetName in planets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planetName}");
            }
        }

        static string DecryptedMessage(string encryptedMessage)
        {
            StringBuilder decryptedMessage = new StringBuilder();
            int decryptionStep = GetDecryptionStep(encryptedMessage);

            foreach (char oldChar in encryptedMessage)
            {
                decryptedMessage.Append((char)(oldChar - decryptionStep));
            }
            return decryptedMessage.ToString();
        }

        static int GetDecryptionStep(string encryptedMessage)
        {
            int decryptionStep = 0;

            foreach (char ch in encryptedMessage.ToLower())
            {
                if (ch == 's' || ch == 't' || ch == 'a' || ch == 'r')
                {
                    decryptionStep++;
                }
            }
            return decryptionStep;
        }
    }
}
