using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : IBorn
    {
        public Pet(string name,string date)
        {
            Name = name;
            BirthDate = date;
        }
        public string BirthDate { get; set; }
        public string Name { get; set; }
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
