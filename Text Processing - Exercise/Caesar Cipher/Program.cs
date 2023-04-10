using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();

            foreach (char currChar in input)
            {
                int currPosition = currChar;
                currPosition += 3;
                sb.Append((char)currPosition);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
