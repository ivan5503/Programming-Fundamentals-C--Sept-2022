using System;

namespace Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsNumber = int.Parse(Console.ReadLine());
            double numberOfLectures = int.Parse(Console.ReadLine());
            double additionalBonus = int.Parse(Console.ReadLine());
            double attendanceOfEachStudent = 0;
            double attendanceOfTheGivenStudent = 0;
            double totalBonus = 0;
            double maximumBonusPoints = double.MinValue;

            if (studentsNumber == 0 || numberOfLectures == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }
            for (int i = 1; i <= studentsNumber; i++)
            {
                attendanceOfEachStudent = int.Parse(Console.ReadLine());

                totalBonus = (attendanceOfEachStudent / numberOfLectures) * (5 + additionalBonus);
                if (totalBonus > maximumBonusPoints)
                {
                    maximumBonusPoints = totalBonus;
                    attendanceOfTheGivenStudent = attendanceOfEachStudent;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Round(maximumBonusPoints)}.");
            Console.WriteLine($"The student has attended {attendanceOfTheGivenStudent} lectures.");
        }
    }
}
