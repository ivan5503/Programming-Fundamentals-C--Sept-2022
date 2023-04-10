using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            long[] row = new long[nLines];
            long[] col = new long[nLines];

            row[0] = 1;
            Console.WriteLine(row[0]);

            for (int r = 1; r < nLines; r++)
            {

                for (int c = 0; c <= r; c++)
                {

                    if (c == 0)
                    {
                        col[c] = 0 + row[c];
                    }
                    else
                    {
                        col[c] = row[c - 1] + row[c];
                    }
                    Console.Write($"{col[c]} ");
                }
                Console.WriteLine();
                for (int j = 0; j < nLines; j++)
                {
                    row[j] = col[j];
                }
            }
 
        }
    }
}
