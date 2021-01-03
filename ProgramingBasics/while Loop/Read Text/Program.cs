using System;

namespace Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "Stop")
                {
                     
                    break;
                }
                else
                {
                    Console.WriteLine(name);
                }
                
            }
        }
    }
}
