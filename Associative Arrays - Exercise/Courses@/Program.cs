using System;
using System.Collections.Generic;

namespace Courses_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();


            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(":");
                string courseName = command[0];
                string studentName = command[1];

                if (!dictionary.ContainsKey(courseName))
                {
                    dictionary.Add(courseName, new List<string>());
                }
                dictionary[courseName].Add(studentName);
            }
            foreach (var course in dictionary)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }

            }
        }
    }
}
