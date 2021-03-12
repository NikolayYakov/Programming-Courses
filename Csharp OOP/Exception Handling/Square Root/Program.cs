using System;

namespace Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentException("Invalid Number");
                }
                double result = Math.Sqrt(number);
                Console.WriteLine(result);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
            
            
        }
    }
}
