using System;
using System.Linq;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0');
            int multiplayer = int.Parse(Console.ReadLine());
            if (number == "0" || multiplayer == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int temp = 0;
            StringBuilder result = new StringBuilder();
            foreach (char digit in number.Reverse())
            {
                
                int digitNumber = int.Parse(digit.ToString());
                int finale = digitNumber * multiplayer + temp;
                temp = finale/ 10;
                int restDigit = finale % 10;
                result.Insert(0,restDigit);
            }
            if (temp != 0)
            {
                result.Insert(0, temp);
            }
            Console.WriteLine(result);
        }
    }
}
