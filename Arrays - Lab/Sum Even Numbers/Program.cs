using System;
using System.Linq;

namespace Sum_Even_Numbers1
{
    class Program
    { 
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenValue += arr[i];
                }


            }
            Console.WriteLine("{0}", evenValue);
                


        }
    }
}
