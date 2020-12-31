using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            double studentGpa = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());
            double academicScholarship = 0;
            double socialScholarship = 0;
            if (studentGpa >= 5.50)
            {
                academicScholarship = studentGpa * 25;
            }
            if (salary < minimalSalary)
            {
                if (studentGpa > 4.50)
                {
                    socialScholarship = minimalSalary *35 / 100;
                }
            }
            bool check = academicScholarship == socialScholarship;
            if (check==true)
            {
                if (socialScholarship == 0)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            else if (socialScholarship <= academicScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor( academicScholarship)} BGN");
            }
            else if (socialScholarship > academicScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
           
        }
    }
}
