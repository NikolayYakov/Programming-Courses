using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name,double weight,string livingRegion)
            :base(name,weight,livingRegion)
        {

        }
        public override void Eat(Food food)
        {
            Console.WriteLine("Squeak");
            if(!(food is Vegetable)&&!(food is Fruit))
            {
                Console.WriteLine($"Mouse does not eat {food}!");
            }
            else
            {
                double eatFood = 0.10 * food.Quantity;
                Weight += eatFood;
                FoodEaten += food.Quantity;
            }
        }
        public override string ToString()
        {
            return $"Mouse [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
