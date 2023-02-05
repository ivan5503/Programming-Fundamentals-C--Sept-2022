using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int addOperation = firstNum + secondNum;
            int divideOperation = addOperation / thirdNum;
            int multiplyOperation = divideOperation * fourthNum;

            Console.WriteLine(multiplyOperation);

        }
    }
}
