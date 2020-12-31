using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();
            
             
            if (inputUnit == "cm")
            {
                if(outputUnit=="m")
                {
                    number /= 100;
                }
                else
                {
                    number *= 10;
                }
            }
            else if (inputUnit == "m")
            {
                if (outputUnit == "cm")
                {
                    number *= 100;
                }
                else
                {
                    number *= 1000;
                }
            }
            else
            {
                if (outputUnit == "cm")
                {
                    number /= 10;
                }
                else
                {
                    number /= 1000;
                }
            }
            Console.WriteLine($"{number:f3}");
        }
    }
}
