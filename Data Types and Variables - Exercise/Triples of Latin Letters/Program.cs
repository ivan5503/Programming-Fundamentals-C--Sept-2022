using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + n; i++)
            {
                for (int j = 97; j < 97 + n; j++)
                {
                    for (int k = 97; k < 97 + n; k++)
                    {
                        char I = (char)i;
                        char J = (char)j;
                        char K = (char)k;

                        Console.WriteLine("{0}{1}{2}", I, J, K);
                    }
                }
            }
        }
    }
}
