using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    class Smartphone : ISmartphone
    {
        public void Brows(string url)
        {
            bool isDigit = false;
            for (int i = 0; i < url.Length; i++)
            {
                if (char.IsDigit(url[i]))
                {
                    isDigit = true;
                    break;
                }
            }
            if(isDigit == false)
            {
                Console.WriteLine($"Browsing: {url}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
            
        }

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
            if(isNumber == true)
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
