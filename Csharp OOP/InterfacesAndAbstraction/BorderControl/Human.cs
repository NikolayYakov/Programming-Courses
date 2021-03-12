using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Human : IIdentifiable

    {
        public Human(string name,int age,string id)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Fake(string fakeDigit)
        {
            string last = Id.Substring(Id.Length - fakeDigit.Length);
            
            if (last == fakeDigit)
            {
                Console.WriteLine(Id);
            }
        }
    }
}
