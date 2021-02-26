using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
     
    public class Engine
    {
        private List<Animal> animals;
        public Engine()
        {
            animals = new List<Animal>();
        }
        public void Run()
        {
            string command;
            
            while ((command = Console.ReadLine()) != "Beast!")
            {
                string[] tocken = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tocken[0];
                int age = int.Parse(tocken[1]);
                Animal animal;
                try
                {
                    animal = GetAnimal(command, tocken);
                }
                catch (Exception ex) 
                {

                    Console.WriteLine(ex.Message);
                    continue;
                }
                
                 
                animals.Add(animal);
                
                
            }
            
            PrintOutput();
        }
        private Animal GetAnimal(string command,string[] tocken)
        {
            string name = tocken[0];
            int age = int.Parse(tocken[1]);
            Animal animal = null;
            if (command == "Dog")
            {
                animal = new Dog(name, age, tocken[2]);
            }
            else if (command == "Cat")
            {
                animal = new Cat(name, age, tocken[2]);
            }
            else if (command == "Frog")
            {
                animal = new Frog(name, age, tocken[2]);

            }
            else if (command == "Kitten")
            {
                animal = new Kitten(name, age);

            }
            else if (command == "Tomcat")
            {
                animal = new Tomcat(name, age);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }
            return animal;
                
        }
        private void PrintOutput()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
         
    }
}
