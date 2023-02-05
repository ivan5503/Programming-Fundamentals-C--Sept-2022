using System;
using System.Linq;

namespace Reverse_Array_of_Strings1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] arr = new string[elements.Length];
            string frontElement = string.Empty;
            string backElement = string.Empty;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                backElement = elements[i];
                frontElement = elements[(elements.Length - 1) - i];


                elements[i] = frontElement;
                elements[(elements.Length - 1) - i] = backElement;
                
            }
            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
