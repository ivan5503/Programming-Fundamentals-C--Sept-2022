using System;
using System.Numerics;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            ulong days =  (ulong)(365.2422 * years);
            ulong hours =  days * 24;
            BigInteger minutes = (BigInteger)hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);




        }
    }
}
