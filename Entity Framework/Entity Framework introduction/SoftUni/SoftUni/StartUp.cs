using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
             
            SoftUniContext context = new SoftUniContext();
            var result = RemoveTown(context);
            Console.WriteLine(result);
            
        }
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var info = context.Employees.Select(x => new { x.EmployeeId, x.FirstName, x.LastName, x.MiddleName, x.JobTitle, x.Salary }).OrderBy(x => x.EmployeeId).ToList();
            foreach (var data in info)
            {
                sb.AppendLine($"{data.FirstName} {data.LastName} {data.MiddleName} {data.JobTitle} {data.Salary:f2}");

            }
            return sb.ToString();

        }
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var info = context.Employees.Select(x => new { x.FirstName, x.Salary }).Where(x => x.Salary > 50000).OrderBy(x => x.FirstName).ToList();
            foreach (var data in info)
            {
                sb.AppendLine($"{data.FirstName} - {data.Salary:f2}");
            }
            return sb.ToString();

        }
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var info = context.Employees.Select(x => new { x.FirstName,x.LastName,DepartmentName = x.Department.Name, x.Salary })
                .Where(x => x.DepartmentName == "Research and Development")
                .OrderBy(x => x.Salary).ThenByDescending(x=>x.FirstName)
                .ToList();
            foreach (var data in info)
            {
                sb.AppendLine($"{data.FirstName} {data.LastName} from {data.DepartmentName} - ${data.Salary:f2}");
            }
            return sb.ToString();
        }
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var address = new Address { AddressText = "Vitoshka 15", TownId = 4 };
            context.Addresses.Add(address);
            var employee = context.Employees.Where(x=>x.LastName=="Nakov").ToList()[0];
            employee.Address = address;
            context.SaveChanges();
            StringBuilder sb = new StringBuilder();
            var info = context.Employees.OrderByDescending(x => x.AddressId).Take(10).Select(x => new { AddressText = x.Address.AddressText });
            foreach (var data in info)
            {
                sb.AppendLine(data.AddressText);
            }
            return sb.ToString();
        }
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var info = context.Employees
                .Where(x => x.EmployeesProjects.Where(e=>e.Project.StartDate.Year>=2001&& e.Project.StartDate.Year <= 2003).Count()>0)
                .Select(x => new {x.EmployeeId, FirstName = x.FirstName, LastName = x.LastName, ManagerFirstName = x.Manager.FirstName, ManagaerLastName = x.Manager.LastName })
                .Take(10)
                .ToList();

            foreach (var data in info)
            {
                sb.AppendLine($"{data.FirstName} {data.LastName} - Manager: {data.ManagerFirstName} {data.ManagaerLastName}");
                var projects = context.EmployeesProjects.Where(e => e.EmployeeId == data.EmployeeId)
                .Select(x => new { ProjectName = x.Project.Name, StartDate = x.Project.StartDate,
                    EndDate =x.Project.EndDate.HasValue
                            ? x.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture) : "not finished"
                })
                .ToList();
                foreach (var project in projects)
                {
                    sb.AppendLine($"--{project.ProjectName} - {project.StartDate} - {project.EndDate}");
                }
            }
            return sb.ToString();
        }
        public static string GetAddressesByTown(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var info = context.Addresses.OrderByDescending(x => x.Employees.Count()).ThenBy(x => x.Town.Name).ThenBy(x => x.AddressText)
                .Take(10)
                .Select(x => new { x.AddressText, TownName = x.Town.Name, EmployeesCount = x.Employees.Count() })
                .ToList();
            foreach (var address in info)
            {
                sb.AppendLine($"{address.AddressText}, {address.TownName} - {address.EmployeesCount} employees");
            }
            return sb.ToString();

        }
        public static string GetEmployee147(SoftUniContext context)
        {
            var employee = context.Employees.Where(x => x.EmployeeId == 147)
                 .Select(x => new { FirstName =x.FirstName, LastName = x.LastName, JobTitle = x.JobTitle,Projects= x.EmployeesProjects.Select(e=>new {ProjectName = e.Project.Name })})
                 .FirstOrDefault();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                foreach (var project in employee.Projects.OrderBy(x=>x.ProjectName))
                {
                    sb.AppendLine(project.ProjectName);
                }
           
            return sb.ToString();

        }
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var departments = context.Departments.Where(x => x.Employees.Count() > 5).OrderBy(x => x.Employees.Count()).OrderBy(x => x.Name)
                .Select(x => new {DepartmentName = x.Name, ManagerFirstName = x.Manager.FirstName, ManagerLastName = x.Manager.LastName, Employees = x.Employees.Select(em => new { em.FirstName, em.LastName, em.JobTitle }) }).ToList();
            foreach (var department in departments)
            {
                sb.AppendLine($"{department.DepartmentName} - {department.ManagerFirstName} {department.ManagerLastName}");
                foreach (var employee in department.Employees.OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName))
                {
                    sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                }
            }
            return sb.ToString();
        }
        public static string GetLatestProjects(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var projects = context.Projects.OrderByDescending(x => x.StartDate).Take(10)
                .Select(x=>new {x.Name,x.Description,x.StartDate}).ToList();
            foreach (var project in projects.OrderBy(x=>x.Name))
            {
                sb.AppendLine(project.Name);
                sb.AppendLine(project.Description);
                sb.AppendLine(project.StartDate.ToString());
            }
            return sb.ToString();

        }
        public static string IncreaseSalaries(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employees = context.Employees.Where(x => x.Department.Name == "Engineering" || x.Department.Name == "Tool Design" || x.Department.Name == "Information Services" || x.Department.Name == "Marketing")
                                  .OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName)
                                  .ToList();
            foreach (var employee in employees)
            {
                employee.Salary *= 1.12M;
            }
            context.SaveChanges();
            employees = context.Employees.Where(x => x.Department.Name == "Engineering" || x.Department.Name == "Tool Design" || x.Department.Name == "Information Services" || x.Department.Name == "Marketing")
                                  .OrderBy(x => x.FirstName).ThenBy(x => x.LastName)
                                  .ToList();
            foreach (var employee in employees)
            {
                
                sb.AppendLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:f2})");

            }

            return sb.ToString();
            

        }
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employees = context.Employees.Where(x => x.FirstName.StartsWith("Sa")).Select(x => new { x.FirstName, x.LastName, x.JobTitle, x.Salary })
                                             .OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:f2})");
            }
            return sb.ToString();
        }
        public static string DeleteProjectById(SoftUniContext context)
        {
            var project = context.Projects.Find(2);
            var employeeProjects = context.EmployeesProjects.Where(x => x.ProjectId == 2).ToList();
            while (employeeProjects.Count > 0)
            {

                context.EmployeesProjects.Remove(employeeProjects[0]);
                employeeProjects.Remove(employeeProjects[0]);
              
            }
            context.Projects.Remove(project);
            context.SaveChanges();
            StringBuilder sb = new StringBuilder();
            var projects = context.Projects.Take(10).Select(x => x.Name);
            foreach (var item in projects)
            {
                sb.AppendLine(item);
            }
            return sb.ToString();
        }
        public static string RemoveTown(SoftUniContext context)
        {

            var emp = context.Employees
                .Where(e => e.Address.Town.Name == "Seattle");

            foreach (var e in emp)
            {
                e.AddressId = null;
            }

            var addresses = context.Addresses.Where(a => a.Town.Name == "Seattle");
            int count = addresses.Count();
            context.Addresses.RemoveRange(addresses);
            var town = context.Towns.Where(t => t.Name == "Seattle").ToList();
            context.Towns.Remove(town.First());
            context.SaveChanges();

            return $"{count} addresses in Seattle were deleted";
        }

    }
   
}
