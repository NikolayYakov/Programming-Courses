using System;

namespace ValidPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(" ");
            string first = null;
            string second = data[1];
            int age = int.Parse(data[2]);
            try
            {
                Person person = new Person(first, second, age);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
