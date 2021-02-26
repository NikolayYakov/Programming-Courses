using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private const string ErrorMessage = "Invalid input!";
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ErrorMessage);
                }
                name = value;
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
                if (value < 0)
                {
                    throw new ArgumentException(ErrorMessage);
                }

                this.age = value;
            }
        }

        public  string Gender
        {
            get
            {
                return gender;
            }
            private set
            {
                if ((value!="Male"&&value!="Female"))
                {
                    throw new ArgumentException(ErrorMessage);
                }
                gender = value;
            }
        }

        public abstract string ProduceSound();
         

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(this.GetType().Name)
                .AppendLine($"{this.name} {this.age} {this.gender.ToString()}")
                .Append($"{this.ProduceSound()}");

            return builder.ToString().Trim();
        }
    }
}
