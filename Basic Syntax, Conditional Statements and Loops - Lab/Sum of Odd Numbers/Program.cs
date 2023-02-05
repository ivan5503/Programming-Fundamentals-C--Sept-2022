using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNumbers = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            for (int i = 1; i <= 100; i += 2)
            {
                counter++;
                Console.WriteLine(i);
                sum += i;
                if (oddNumbers == counter)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
