using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    { 
        static void Main(string[] args)
        {  
            int[] arr = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int currNumber = 0;
            if (arr.Length - 1 == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {

                currNumber = arr[i];
                int rightSum = 0; 
                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }
                int leftSum = 0;
                if (i == 0)
                {
                    leftSum = 0;
                }
                else
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        leftSum += arr[j];
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
               

            }
            Console.WriteLine("no");
        }
    }
}
