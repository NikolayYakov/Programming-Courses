using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    class Bakery
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return date.Count; } }
        private List<Employee> date;
        public Bakery(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
            date = new List<Employee>();
        }
        public void Add(Employee employee)
        {
            if (date.Count < Capacity)
            {
                date.Add(employee);
            }
        }
        public bool Remove(string name)
        {
           var person = date.FirstOrDefault(e => e.Name == name);
            if (person == null)
            {
                return false;
            }
            date.Remove(person);
            return true;
            
        }
        public Employee GetOldestEmployee()
        {
            var orderDate = date.OrderByDescending(n => n.Age);
            var person = date.FirstOrDefault(n => n.Age > 0);
            return person;
        }
        public Employee GetEmployee(string name)
        {
            var person = date.FirstOrDefault(n => n.Name == name);
            return person;
        }
        public string Report()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Employees working at Bakery {Name}");
            foreach (var item in date)
            {
                output.AppendLine($"{item}");
            }
            return output.ToString();
        }


    }
}
