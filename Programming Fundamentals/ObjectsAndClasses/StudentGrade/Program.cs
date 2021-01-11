using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>(studentCount);
            for(int i = 0; i < studentCount; i++)
            {
                string[] studentInfo = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            List<Student> fillter = students.OrderByDescending(s => s.Grade).ToList();
            foreach (Student s in fillter)
            {
                Console.WriteLine($"{s.FirstNmae} {s.LastName}: {s.Grade:f2}");
            }
        }
    }
    class Student
    {
        public Student(string firtsName,string lastName,double grade)
        {
            FirstNmae = firtsName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstNmae { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
