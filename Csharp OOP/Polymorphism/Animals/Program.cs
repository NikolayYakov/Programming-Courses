using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Pesho", "Wiskas");
            Animal dog = new Dog("Gosho", "Meat");
            Console.WriteLine(dog.ExplainSelf());
            Console.WriteLine(cat.ExplainSelf());
        }
    }
}
