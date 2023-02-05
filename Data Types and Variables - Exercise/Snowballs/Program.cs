using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsNum = int.Parse(Console.ReadLine());
            BigInteger bestSnowball = int.MinValue;
            BigInteger snowballValue = 0;
            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            int snowballQuality = 0;
            BigInteger snow = 0;
            BigInteger time = 0;
            int quality = 0;
            for (int i = 1; i <= snowballsNum; i++)
            {
                snowballSnow = BigInteger.Parse(Console.ReadLine());
                snowballTime = BigInteger.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = snowballSnow / snowballTime;
                snowballValue = BigInteger.Pow(snowballValue, snowballQuality);

                if (snowballValue > bestSnowball)
                {
                    bestSnowball = snowballValue;
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;

                }
            }
            Console.WriteLine($"{snow} : {time} = {bestSnowball} ({quality})");		

        }
    }
}
