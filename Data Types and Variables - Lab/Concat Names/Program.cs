using System;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = " ";
            string secondName = " ";
            for (int i = 1; i<= 2; i++)
            {
                string names = Console.ReadLine();

                if (i == 1)
                {
                    firstName = names;
                }
                else
                {
                    secondName = names;
                }
            }
            string delimeter = Console.ReadLine();
            Console.WriteLine("{0}{1}{2}", firstName, delimeter, secondName);

        }
    }
}
