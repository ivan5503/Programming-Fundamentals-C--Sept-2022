using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            MatrixCreator(input);

        }
        static void MatrixCreator(int input)
        {
            for (int rows = 0; rows < input; rows++)
            {
                for (int colls = 0; colls < input; colls++)
                {
                    Console.Write(input + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
