using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    class Stationary : IStationary
    {
        public void Call(string number)
        {
            bool isNumber = true;
            for (int i = 0; i < number.Length; i++)
            {
                if (!char.IsDigit(number[i]))
                {
                    isNumber = false;
                    break;
                }
            }
            if (isNumber == true)
            {
                Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
