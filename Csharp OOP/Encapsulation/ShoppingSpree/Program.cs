using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] people = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                List<Person> legitPeople = new List<Person>();
                List<Product> legitProduct = new List<Product>();
                string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < people.Length; i++)
                {
                    string[] data = people[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = data[0];
                    double money = double.Parse(data[1]);
                    Person person = new Person(name, money);
                    legitPeople.Add(person);

                }
                for (int i = 0; i < products.Length; i++)
                {
                    string[] data = products[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = data[0];
                    double cost = double.Parse(data[1]);
                    Product product = new Product(name, cost);
                    legitProduct.Add(product);

                }
                string command = Console.ReadLine();
                while (command != "END")
                {
                    string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string name = data[0];
                    string product = data[1];
                    int personIndex = -1;
                    int productIndex = -1;
                    for (int i = 0; i < legitPeople.Count; i++)
                    {
                        if (name == legitPeople[i].Name)
                        {
                            personIndex = i;
                            break;
                        }
                    }
                    for (int i = 0; i < legitProduct.Count; i++)
                    {
                        if (product == legitProduct[i].Name)
                        {
                            productIndex = i;
                            break;
                        }
                    }
                    Person person = legitPeople[personIndex];
                    person.AddProduct(legitProduct[productIndex]);
                    command = Console.ReadLine();
                }
                foreach (var item in legitPeople)
                {
                    if (item.Bag.Count > 0)
                    {
                        Console.WriteLine($"{item.Name} - {string.Join(", ", item.Bag)}");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name} - Nothing bought");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
             
        }
    }
}
