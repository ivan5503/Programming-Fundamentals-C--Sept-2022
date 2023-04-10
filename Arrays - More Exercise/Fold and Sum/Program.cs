using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] createSecondRowAndSumBoth = new int[firstRow.Length / 2];

            int lengthFirstRow = firstRow.Length;
            int firstRowQuarterLength = lengthFirstRow * 20 / 100;
            
            int counter = 0;
            for (int i = firstRowQuarterLength; i >= 0; i--)
            {
                createSecondRowAndSumBoth[counter] = firstRow[i];
                counter++;            
            }
            for (int j = firstRow.Length - 1; j >= (firstRow.Length - 1)- firstRowQuarterLength; j--)
            {
                createSecondRowAndSumBoth[counter] = firstRow[j];
                counter++;
            }
            counter = 0;
            for (int k = firstRowQuarterLength + 1; k < (firstRow.Length - 1) - firstRowQuarterLength; k++)
            {
                createSecondRowAndSumBoth[counter] = createSecondRowAndSumBoth[counter] + firstRow[k];
                counter++;
            }
            Console.WriteLine(string.Join(" ", createSecondRowAndSumBoth));
        }
    }
}
