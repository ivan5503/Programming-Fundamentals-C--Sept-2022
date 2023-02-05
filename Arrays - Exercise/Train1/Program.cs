using System;

namespace Train1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] peopleInEachWagon = new int[numberOfWagons];

            int sum = 0;
            for (int i = 0; i < peopleInEachWagon.Length; i++)
            {
                peopleInEachWagon[i] = int.Parse(Console.ReadLine());

            }
            for (int j = 0; j < peopleInEachWagon.Length; j++)
            {
                sum += peopleInEachWagon[j];
            }
            Console.WriteLine(string.Join(" ", peopleInEachWagon));
            Console.WriteLine(sum);
        }
    }
}
