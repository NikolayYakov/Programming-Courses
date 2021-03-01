using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaData = Console.ReadLine().Split(" ");
            string[] doughData = Console.ReadLine().Split(" ");
            string name = pizzaData[1];
            try
            {
                Dough dough = new Dough(doughData[1], doughData[2], int.Parse(doughData[3]));
                Pizza pizza = new Pizza(name, dough);
                string command = Console.ReadLine();
                while (command != "END")
                {
                    string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (data[0] == "Topping")
                    {
                        Topping topping = new Topping(data[1], int.Parse(data[2]));
                        pizza.AddTopping(topping); 
                    }
                    command = Console.ReadLine();
                }
                Console.WriteLine($"{pizza.Name} - {pizza.Callories():f2} Calories.");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                 
            }
             
        }
    }
}
