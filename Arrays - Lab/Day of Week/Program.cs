using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysNumber = int.Parse(Console.ReadLine());
            string[] daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


            if (daysNumber >= 1 && daysNumber <= 7)
            {
                Console.WriteLine("{0}", daysOfWeek[daysNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }


        }
    }
}
