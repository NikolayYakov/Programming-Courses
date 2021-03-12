using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Human :IBorn
    {
        public Human(string name,int age,string id,string date)
        {
            Id = id;
            Name = name;
            Age = age;
            BirthDate = date;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string BirthDate { get; set; }

        public void BirthYear(string year)
        {
            string[] tocken = BirthDate.Split("/", StringSplitOptions.RemoveEmptyEntries);
            if (tocken[2] == year)
            {
                Console.WriteLine(BirthDate);
            }
        }
    }
}
