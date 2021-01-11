using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {


        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string[] command = Console.ReadLine()
                                      .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "end")
            {
                string course = command[0];
                string student = command[1];
                if (courses.ContainsKey(course))
                {
                    courses[course].Add(student);

                }
                else
                {
                    courses.Add(course, new List<string>());
                    courses[course].Add(student);
                }
                command = Console.ReadLine()
                                 .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var course in courses.OrderByDescending(s => s.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }

            }

        }
    }
}

