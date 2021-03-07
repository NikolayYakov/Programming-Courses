using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name,double weight,string livingRegion,string breed)
            :base(name,weight,livingRegion,breed)
        {

        }
        public override void Eat(Food food)
        {
            Console.WriteLine("ROAR!!!");
            if(food is Meat)
            {
                double Eaten = food.Quantity * 1.0;
                Weight += Eaten;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Tiger does not eat {food}!");
            }
        }
        public override string ToString()
        {
            return $"Tiger [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";

        }
    }
}
