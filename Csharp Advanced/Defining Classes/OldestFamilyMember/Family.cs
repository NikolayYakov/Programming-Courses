using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> People { get; set; }
        public void AddMember(Person member)
        {
            People.Add(member);
        }
        public Person GetOldestMember()
        {
            Person oldest = new Person();
            oldest.Age = int.MinValue;
            foreach (var person in People)
            {
                if (person.Age > oldest.Age)
                {
                    oldest.Name = person.Name;
                    oldest.Age = person.Age;
                }

            }
            return oldest;
        }
    }
}
