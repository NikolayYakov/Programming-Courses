using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        private string name;
        private int age;
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                name = value;
            }
        }
        public virtual int Age
        {
            get
            {
                return age;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                this.age = value;
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));

            return stringBuilder.ToString();
        }

    }
}
