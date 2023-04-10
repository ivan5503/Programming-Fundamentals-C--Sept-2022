using System;
using System.Text;

namespace Multiply_Big_Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int oneInMind = 0;
            if (multiplyer == 0 || bigNumber == "0")
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                string number = string.Empty;
                char currCh = bigNumber[i];
                number += currCh;
                int product = int.Parse(number);

                product = oneInMind + product * multiplyer;

                int result = product % 10;
                oneInMind = product / 10;

                sb.Append(result.ToString());

            }
            if (oneInMind != 0)
            {
                sb.Append(oneInMind.ToString());
            }
            for (int j = sb.Length - 1; j >= 0; j--)
            {
                string num = string.Empty;
                char currentCh = sb[j];
                num += currentCh;
                int singleDigit = int.Parse(num);
                Console.Write(singleDigit);
            }
            Console.WriteLine();
        }
    }
}
