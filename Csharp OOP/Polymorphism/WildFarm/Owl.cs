using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name,double weight,double wingSize)
            :base(name,weight,wingSize)
        {

        }
        public override void Eat(Food food)
        {
            Console.WriteLine("Hoot Hoot");
            if (food is Meat)
            {
                double Eaten = food.Quantity * 0.25;
                Weight += Eaten;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Owl does not eat {food}!");
            }
        }
        public override string ToString()
        {
            return $"Owl [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
