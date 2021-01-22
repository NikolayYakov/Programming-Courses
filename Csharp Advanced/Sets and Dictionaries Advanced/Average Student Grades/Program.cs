using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                string[] studentGrade = Console.ReadLine().Split();
                string name = studentGrade[0];
                decimal grade = decimal.Parse(studentGrade[1]);
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal>());
                }
                students[name].Add(grade);
            }
            foreach (var student in students)
            {
                
                Console.Write($"{student.Key} -> ");
               for(int i = 0; i < student.Value.Count; i++)
                {
                    Console.Write($"{student.Value[i]:F2} ");
                }
                Console.Write($"(avg: {student.Value.Average():F2})");
                Console.WriteLine();
            }
        }
    }
}
