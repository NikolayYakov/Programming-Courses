using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
   public class Classroom
    {
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count { get { return students.Count; } }
        public List<Student> students;
        public string RegisterStudent(Student student)
        {
            if (students.Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
            
        }
        public string DismissStudent(string firstName, string lastName)
        {
            var student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            if (student != null)
            {
                students.Remove(student);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
            
        }
        public string GetSubjectInfo(string subject)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Subject: {subject}");
            output.AppendLine("Students:");
            List<Student> fillter = students.Where(s => s.Subject == subject).ToList();
            if (fillter.Count <= 0)
            {
                return "No students enrolled for the subject";
            }
            foreach (var student in fillter)
            {
                output.AppendLine($"{student.FirstName} {student.LastName}");
            }

            return output.ToString().Trim();
        }
        public int GetStudentsCount()
        {
            return Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {
            var student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            return student;
        }

    }
}
