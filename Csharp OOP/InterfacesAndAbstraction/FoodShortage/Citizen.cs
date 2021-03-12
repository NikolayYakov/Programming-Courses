using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Citizen:IBuyer
    {
        public Citizen(string name,int age,string id,string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string BirthDate { get; set; }
        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
