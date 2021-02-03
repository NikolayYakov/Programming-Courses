using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person pesho = new Person();
            pesho.Name = "pesho";
            pesho.Age = 30;
            Person gosho = new Person();
            gosho.Name = "gosho";
            gosho.Age = 32;
            Console.WriteLine($"{pesho.Name} на {pesho.Age} e priqtel na {gosho.Name} na {gosho.Age}");

        }
    }
}
