using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int additionalCourse = 0;
            int courses = 0;
            

            if (people < capacity)
            {
                courses = 1;
            }
            else
            {
                courses = people / capacity;
            }
            if (people % capacity != 0 && people > capacity)
            {
                additionalCourse++;
                courses += additionalCourse;
            }
            Console.WriteLine(courses);
            
        }
    }
}
