using System;
using System.Collections.Generic;

namespace List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            List<string> listOfProducts = new List<string>();
            string product = string.Empty;
            for (int i = 0; i < nLines; i++)
            {
                product = Console.ReadLine();
                listOfProducts.Add(product);
            }
            listOfProducts.Sort();
            int productCounter = 1;
            for (int j = 0; j < listOfProducts.Count; j++)
            {
                Console.WriteLine("{0}.{1}",productCounter++,listOfProducts[j]);
            }

        }
    }
}
