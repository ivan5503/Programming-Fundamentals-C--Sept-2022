using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());
            uint consumedByWorkersPerDay = 26;
            uint yieldPerDay = 0;
            int daysCounter = 0;
            uint droppingYieldPerDay = 10;
            uint totalYield = 0;
            uint minimumSpices = 100;
            while (startingYield >= minimumSpices)
            {
                daysCounter++;
                yieldPerDay = startingYield - consumedByWorkersPerDay;
                totalYield += yieldPerDay;
                startingYield -= droppingYieldPerDay;
                if (startingYield < minimumSpices)
                {
                    totalYield -= consumedByWorkersPerDay;
                }
               

            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(totalYield);
        }
    }
}
