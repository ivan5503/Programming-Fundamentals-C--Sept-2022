using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] firstArr = new int[lines];
            int[] secondArr = new int[firstArr.Length];
            
            for (int i = 0; i < lines; i++)
            {

                string[] arr = Console.ReadLine().Split(" ");
                if (i % 2 == 0)
                {
                    firstArr[i] = int.Parse(arr[0]);
                    secondArr[i] = int.Parse(arr[1]);
                }
                else
                {
                    secondArr[i] = int.Parse(arr[0]);
                    firstArr[i] = int.Parse(arr[1]);
                }

            }
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
            
        }
    }
}
