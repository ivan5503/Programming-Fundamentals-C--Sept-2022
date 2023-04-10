using System;

namespace Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = new string[] {"zero","one","two","three","four","five","six","seven","eight","nine"};
            int num = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (i == input.Length - 1)
                {
                    num = int.Parse(input[i].ToString());
                    break;
                }
            }
            for (int j = 0; j < nums.Length; j++)
            {
                if (num == j)
                {
                    Console.WriteLine(nums[j]);
                    break;
                }
            }
        }
    }
}
