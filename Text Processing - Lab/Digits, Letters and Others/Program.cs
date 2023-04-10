using System;
using System.Linq;
using System.Text;

namespace Digits__Letters_and_Others
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] digits = input.Where(ch => char.IsDigit(ch)).ToArray();
            char[] letters = input.Where(ch => char.IsLetter(ch)).ToArray();
            char[] symbols = input.Where(ch => !char.IsLetterOrDigit(ch)).ToArray();

            
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
