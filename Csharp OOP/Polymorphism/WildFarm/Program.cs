using System;
using System.Collections.Generic;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Animal> animals = new List<Animal>();
            while(command!= "End")
            {
                string animalInfo = command;
                string foodInfo = Console.ReadLine();
                string[] foodTocken = foodInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string foodName = foodTocken[0];
                int quantity = int.Parse(foodTocken[1]);
                Food food = null;
                if(foodName== "Vegetable")
                {
                    food = new Vegetable(quantity);
                }
                else if(foodName== "Fruit")
                {
                    food = new Fruit(quantity);
                }
                else if(foodName== "Meat")
                {
                    food = new Meat(quantity);
                }
                else if(foodName== "Seeds")
                {
                    food = new Seeds(quantity);
                }
                string[] tocken = animalInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tocken[1];
                double weight = double.Parse(tocken[2]);
                Animal animal = null;
                if (tocken[0] == "Owl")
                {
                    double wingSize = double.Parse(tocken[3]);
                    animal = new Owl(name, weight, wingSize);
                }
                else if(tocken[0]== "Hen")
                {
                    double wingSize = double.Parse(tocken[3]);
                    animal = new Hen(name, weight, wingSize);
                }
                else if(tocken[0]== "Mouse")
                {
                    string region = tocken[3];
                    animal = new Mouse(name, weight, region);
                }
                else if (tocken[0] == "Dog")
                {
                    string region = tocken[3];
                    animal = new Dog(name, weight, region);
                }
                else if (tocken[0] == "Cat")
                {
                    string region = tocken[3];
                    string breed = tocken[4];
                    animal = new Cat(name, weight, region, breed);
                }
                else if (tocken[0] == "Tiger")
                {
                    string region = tocken[3];
                    string breed = tocken[4];
                    animal = new Tiger(name, weight, region, breed);
                }
                animals.Add(animal);
                animal.Eat(food);
                command = Console.ReadLine();
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
