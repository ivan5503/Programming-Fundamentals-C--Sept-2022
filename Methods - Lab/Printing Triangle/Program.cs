using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int start = 1;
            PrintingTrianglePart1(start, end);
            PrintingTrianglePart2(start, end - 1);
          
        }

        static void PrintingTrianglePart2(int start, int end)
        {
            for (int k = end; k >= start; k--)
            {
                for (int j = start; j <= k; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintingTrianglePart1(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
