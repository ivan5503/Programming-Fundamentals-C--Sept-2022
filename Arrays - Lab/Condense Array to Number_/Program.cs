using System;
using System.Linq;

namespace Condense_Array_to_Number_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] arrOfIntegers = input.Split().Select(int.Parse).ToArray();
            
            for (int j = 0; j < arrOfIntegers.Length - 1; j++)
            {
                for (int i = 0; i < arrOfIntegers.Length - 1; i++)
                {
                    arrOfIntegers[i] = arrOfIntegers[i] + arrOfIntegers[i + 1];

                }
                arrOfIntegers[arrOfIntegers.Length - j - 1] = 0;
                
            }
            int condensedToASingleNumber = arrOfIntegers[0];
            Console.WriteLine(condensedToASingleNumber);
            

        }
    }
}
