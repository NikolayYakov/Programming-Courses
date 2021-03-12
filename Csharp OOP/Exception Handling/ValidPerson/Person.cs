using System;
using System.Collections.Generic;
using System.Text;

namespace ValidPerson
{
   public class Person
    {
        private string first;
        private string second;
        private int age;
        public Person(string first,string second,int age)
        {
            First = first;
            Second = second;
            Age = age;
        }
        public string First
        {
            get
            {
                return first;
            }
           private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name shount not be Null ot empty");
                }
                first = value;
            }
        }
        public string Second
        {
            get
            {
                return second;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name shount not be Null ot empty");
                }
                second = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Age should be in a range [0-120]");
                }
            }

        }
    }
}
