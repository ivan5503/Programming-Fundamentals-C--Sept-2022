using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] result = new int[arr.Length];

            int rotations = int.Parse(Console.ReadLine());
            rotations = rotations % arr.Length;

            for (int i = 1; i <= rotations; i++)
            {
                result[result.Length - 1] = arr[0];
                for (int j = 0; j < result.Length -1; j++)
                {
                    result[j] = arr[j + 1];
                    arr[j] = result[j];
                }
                arr[arr.Length - 1] = result[result.Length - 1];

                
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
