﻿using System;

namespace Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string studenName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:f2} ", studenName,age,averageGrade);
 
        }
    }
}
