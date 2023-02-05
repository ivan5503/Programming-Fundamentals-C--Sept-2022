using System;

namespace Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint meters = uint.Parse(Console.ReadLine());
            double kilometers = (double)meters / 1000;

            Console.WriteLine("{0:F2}", kilometers);
        }
    }
}
