using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Logic
{
    class Person:IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo([AllowNull] Person other)
        {
            if (Name.CompareTo(other.Name) != 0)
            {
                return Name.CompareTo(other.Name);
            }
            return Age.CompareTo(other.Age);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var other = obj as Person;
            if(other == null)
            {
                return false;
            }
            return Age == other.Age && Name == other.Name;

        }
    }
}
