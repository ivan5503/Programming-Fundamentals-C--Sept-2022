using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            double halfPokePower = pokePowerN * 50 / 100.0;            
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionY = int.Parse(Console.ReadLine());
            int pokeCounter = 0;
 
            while (pokePowerN >= distanceM)
            {
                
                 pokePowerN -= distanceM;
                 pokeCounter++;
                 if (pokePowerN == halfPokePower)
                 {
                     

                     pokePowerN /= exhaustionY;
                     
                 }
             
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(pokeCounter);

        }
    }
}
