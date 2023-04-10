using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int efficiencyPerHour = 0;
            int timeNeeded = 0;

            int firstLine = int.Parse(Console.ReadLine());
            int secondLine = int.Parse(Console.ReadLine());
            int thirdLine = int.Parse(Console.ReadLine());

            efficiencyPerHour = firstLine + secondLine + thirdLine;

            int studentsCount = int.Parse(Console.ReadLine());

            if (studentsCount % efficiencyPerHour == 0)
            {
                timeNeeded = studentsCount / efficiencyPerHour;
            }
            else if (studentsCount % efficiencyPerHour != 0)
            {
                timeNeeded = studentsCount / efficiencyPerHour + 1;
            }
            if (timeNeeded > 3 && timeNeeded % 3 == 0)
            {
                timeNeeded += timeNeeded / 3 - 1;
            }
            else if (timeNeeded > 3)
            {
                timeNeeded += timeNeeded / 3;
            }


            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}
