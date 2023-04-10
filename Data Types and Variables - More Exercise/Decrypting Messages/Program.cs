using System;

namespace Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int nLines = int.Parse(Console.ReadLine());

            string descryptedMessage = string.Empty;
            char ch = ' ';

            for (int i = 0; i < nLines; i++)
            {
                ch = char.Parse(Console.ReadLine());

                descryptedMessage += (char)(ch + key);
            }

            Console.WriteLine(descryptedMessage);


        }
    }
}
