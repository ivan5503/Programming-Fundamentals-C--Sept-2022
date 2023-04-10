using System;

namespace Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTribunacciSequence(num);
        }

        private static void PrintTribunacciSequence(int num)
        {
            uint[] arr = new uint[num + 2];
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 2;

            for (int i = 3; i <= num; i++)
            { 
                arr[i] = arr[i - 3] + arr[i - 2] + arr[i - 1];
            }
            for (int j = 0; j < num; j++)
            {
                Console.Write($"{arr[j]} ");
            }
        }
    }
}
