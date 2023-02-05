using System;
using System.Linq;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelsCount = GetVowelsCount(text);
            Console.WriteLine(vowelsCount);
        }
        static int GetVowelsCount(string text)
        {
            int vowelsCount = 0;
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y',};

            foreach (char letter in text.ToLower())
            {
                if (MyContains(vowels, letter))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;

        }
        static bool MyContains(char[] arr,char searchChar)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                char currChar = arr[i];
                if (currChar == searchChar)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
