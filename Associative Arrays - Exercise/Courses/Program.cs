using System;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = command[0];
                string studentName = command[1];

                if (!dictionary.ContainsKey(courseName))
                {
                    dictionary[courseName] = new List<string>();
                }
                dictionary[courseName].Add(studentName);
            }
            foreach (var information in dictionary)
            {

                List<string> students = information.Value;
                Console.WriteLine($"{information.Key}: {students.Count}");
                foreach (var studentNames in students)
                {
                    Console.WriteLine($"-- {studentNames}");
                }
            }
        }
    }
}
