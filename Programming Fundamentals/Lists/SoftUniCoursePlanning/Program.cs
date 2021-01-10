using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine()
                                          .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToList();
            List<string> command = Console.ReadLine()
                                          .Split(":", StringSplitOptions.RemoveEmptyEntries)
                                          .ToList();
            while (command[0].ToLower() != "course start")
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        Add(courses, command[1]);
                        break;
                    case "insert":
                        int indexInsert = int.Parse(command[2]);
                        Insert(courses, command[1], indexInsert);
                        break;
                    case "remove":
                        Remove(courses, command[1]);
                        break;
                    case "swap":
                        Swap(courses, command[1], command[2]);
                        break;
                    case "exercise":
                        Exercise(courses, command[1]);
                        break;
                }
                command = Console.ReadLine()
                                 .Split(":", StringSplitOptions.RemoveEmptyEntries)
                                 .ToList();
            }
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }
        }
        static void Add(List<string> courses,string course)
        {
            if (courses.Contains(course) == false)
            {
                courses.Add(course);
            }
        }
        static void Insert(List<string> courses,string course,int index)
        {
            if (courses.Contains(course) == false)
            {
                courses.Insert(index,course);
            }
        }
        static void Remove(List<string> courses,string course)
        {
            if (courses.Contains(course) == true)
            {
                courses.Remove(course);
                string exercise = course + "-Exercise";
                if (course.Contains(exercise)==true)
                {
                    courses.Remove(exercise);
                }
            }
        }
        static void Swap(List<string> courses, string firstCourse,string secondCourse)
        {
            if (courses.Contains(firstCourse) == true && courses.Contains(secondCourse) == true)
            {
                int firstIndex = courses.IndexOf(firstCourse);
                int secondIndex = courses.IndexOf(secondCourse);
                courses[secondIndex] = firstCourse;
                courses[firstIndex] = secondCourse;
                string firstExercise = firstCourse + "-Exercise";
                string secondExercise = secondCourse + "-Exercise";
                int firstIndexExercise = courses.IndexOf(firstExercise);
                int secondIndexExercise = courses.IndexOf(secondExercise);
                if (courses.Contains(firstExercise) == true && courses.Contains(secondExercise)==true)
                {
                    
                    courses[secondIndexExercise] = firstExercise;
                    courses[firstIndexExercise] = secondExercise;
                }
                if (courses.Contains(firstExercise) == true && courses.Contains(secondExercise) == false)
                {
                    courses.RemoveAt(firstIndexExercise);
                    courses.Insert(secondIndex + 1, firstExercise);
                   
                }
                if(courses.Contains(firstExercise) == false && courses.Contains(secondExercise) == true)
                {
                    courses.RemoveAt(secondIndexExercise);
                    courses.Insert(firstIndex + 1, secondExercise);
                   
                }
            }
        }
        static void Exercise(List<string> courses, string course)
        {
            string exercise = course + "-Exercise";

            if (courses.Contains(course) == true && courses.Contains(exercise) == false)
            {
                int index = courses.IndexOf(course);
                courses.Insert(index + 1, exercise);
            }
           if (courses.Contains(course) == false)
            {
                courses.Add(course);
                courses.Add(exercise);
                  
            }
        }
    }
}
