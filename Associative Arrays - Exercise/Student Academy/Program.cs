using System;
using System.Collections.Generic;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> dictionary = new Dictionary<string, List<double>>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(studentName))
                {
                    dictionary[studentName] = new List<double>();
                }
                dictionary[studentName].Add(grade);
            }
            foreach(var information in dictionary)
            {
                double averageGrade = 0;
                string name = information.Key; 
                List<double> studentsGrades = information.Value;
                
                foreach (var grade in studentsGrades)
                {
                    averageGrade += grade;
                }
                averageGrade = averageGrade / studentsGrades.Count;
                if (averageGrade >= 4.50)
                {
                     Console.WriteLine($"{name} -> {averageGrade:f2}");
                }
            }
        }
    }
}
