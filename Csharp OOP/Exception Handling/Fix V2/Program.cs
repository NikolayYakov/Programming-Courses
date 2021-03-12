using System;

namespace Fix_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            byte result;
            num1 = 30;
            num2 = 60;
            try
            {
                result = Convert.ToByte(num1 * num2);
               
            }
            catch (OverflowException ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine($"{num1}*{num2}={result}");

        }
    }
}
