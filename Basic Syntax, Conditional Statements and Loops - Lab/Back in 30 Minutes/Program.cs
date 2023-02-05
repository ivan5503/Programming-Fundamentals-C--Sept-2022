using System;

namespace Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int waitingTime = 30;
           

            int totalMinutes = waitingTime + minutes;
            int minutesAfter30Min = totalMinutes;

            if (totalMinutes > 59)
            {
                hours += 1;
                minutesAfter30Min = Math.Abs(minutes - waitingTime);
            }
            if (hours > 23 || hours == 0)
            {
                hours = 0;
               
            }
            int hoursAfter30Min = hours;
     

            Console.WriteLine($"{hoursAfter30Min}:{minutesAfter30Min:D2}");







        }
    }
}
