using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (command != "end")
            {
                string[] tokens = command.Split();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName, age);
                    Student targetStudent = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
                    students.Remove(targetStudent);
                    students.Add(student);

                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city,

                    };
                    students.Add(student);
                }

                command = Console.ReadLine();
            }
            string filterCity = Console.ReadLine();
            List<Student> filteredStudents = students.Where(s => s.City == filterCity).ToList();

            foreach (Student student in filteredStudents)
            {

                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName, int age)
        {
            Student ExistingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {

                    student.Age = age;
                    ExistingStudent = student;
                    return ExistingStudent;
                }
            }
            return ExistingStudent;

        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}