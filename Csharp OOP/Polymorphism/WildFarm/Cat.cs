using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            :base(name,weight,livingRegion,breed)
        {

        }
        public override void Eat(Food food)
        {
            Console.WriteLine("Meow");
            if(!(food is Vegetable)&&!(food is Meat))
            {
                Console.WriteLine($"Cat does not eat {food}!");
            }
            else
            {
                double eaten = food.Quantity * 0.30;
                Weight += eaten;
                FoodEaten += food.Quantity;
            }

        }
        public override string ToString()
        {
            return $"Cat [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
