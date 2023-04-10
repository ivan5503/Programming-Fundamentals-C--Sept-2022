using System;

namespace Sort_Numbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                input += Console.ReadLine();
            }
            for (int j = 0; j < input.Length; j++)
            {
                bool isTrue = true;

                double currentNumber = double.Parse(input[j].ToString());
                for (int k = j + 1; k < input.Length - 1; k++)
                {
                    double nextNumber = double.Parse(input[k].ToString());

                    if (currentNumber > nextNumber)
                    {
                        isTrue = false;
                    }
                }
                if (isTrue)
                {
                    Console.WriteLine(currentNumber);
                }
            }
        }
    }
}
