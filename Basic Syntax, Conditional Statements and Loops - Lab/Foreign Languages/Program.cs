using System;

namespace Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameCountry = Console.ReadLine();

            switch (nameCountry)
            {
                case "England":
                    Console.WriteLine("English");break;
                case "USA":
                    Console.WriteLine("English");break;
                case "Mexico":
                    Console.WriteLine("Spanish");break;
                case "Argentina":
                    Console.WriteLine("Spanish");break;
                case "Spain":
                    Console.WriteLine("Spanish");break;
                default:
                    Console.WriteLine("unknown");break;
            }
             
        }
    }
}
