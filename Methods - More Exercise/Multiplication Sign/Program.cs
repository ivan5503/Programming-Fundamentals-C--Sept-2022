using System;

namespace Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();

             int a =  FindIfIsNegativePositiveOrZero(num1);
             int b =  FindIfIsNegativePositiveOrZero(num2);
             int c =  FindIfIsNegativePositiveOrZero(num3);

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("zero");
            }
            else if (a + b + c == 1 || a + b + c == -3)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }

        static int FindIfIsNegativePositiveOrZero(string num)
        {
            if (num[0] == '-') 
            {
                return -1;
            }
            else if (num[0] == '0')
            {
                return 0;
            }
            return 1;  
        }

    }
}
