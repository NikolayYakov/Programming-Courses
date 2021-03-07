using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name,double weight,double wingSize)
            :base(name,weight,wingSize)
        {

        }
        public override void Eat(Food food)
        {
            Console.WriteLine("Cluck");
            double eatFood = food.Quantity * 0.35;
            Weight += eatFood;
            FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            return $"Hen [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
            
        }
    }
}
