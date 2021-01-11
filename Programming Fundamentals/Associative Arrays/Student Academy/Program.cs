using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int studentsCount = int.Parse(Console.ReadLine());
            for(int i = 0; i < studentsCount; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (students.ContainsKey(student))
                {
                    students[student].Add(grade);
                }
                else
                {
                    students.Add(student,new List<double>());
                    students[student].Add(grade);
                }
            }
            foreach (var student in students.Where(x=>x.Value.Average()>=4.50).OrderByDescending(x=>x.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average()}");
            }
        }
    }
}
