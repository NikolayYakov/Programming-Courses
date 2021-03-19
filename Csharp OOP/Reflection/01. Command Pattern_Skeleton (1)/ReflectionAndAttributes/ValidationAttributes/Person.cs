using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class Person
    {
        public Person(string fullName,int age)
        {
            Age = age;
            FullName = fullName;
        }
        [MyRange(12,90)]
        public int Age { get; set; }
        [MyRequired]
        public string FullName { get; set; }
    }
}
