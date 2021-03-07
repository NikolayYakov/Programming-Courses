using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name,double weight,string livingRegion)
            :base(name,weight,livingRegion)
        {

        }
        public override void Eat(Food food)
        {
            Console.WriteLine("Woof!");
            if(food is Meat)
            {
                double Eaten = food.Quantity * 0.40;
                Weight += Eaten;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Dog does not eat {food}!");
            }
        }
        public override string ToString()
        {
            return $"Dog [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";

        }
    }
}
