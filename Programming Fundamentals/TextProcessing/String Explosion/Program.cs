using System;
using System.Collections.Generic;
using System.Linq;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> symbols = text.ToCharArray().ToList();
                                      
            for(int i = 0; i < symbols.Count; i++)
            {
                int value = 0;
                if (symbols[i] == '>')
                {
                     value = int.Parse(symbols[i + 1].ToString());
                    for(int j = i + 1; j < symbols.Count; j++)
                    {
                        if (value <= 0)
                        {
                            break;
                        }
                        if (symbols[j] == '>')
                        {
                            value += int.Parse(symbols[j + 1].ToString());
                            
                        }
                        else
                        {
                            symbols.RemoveAt(j);
                            j--;
                            value--;
                        }
                        i = j;
                    }
                }
                 
            }
            Console.WriteLine(string.Join("", symbols));

            



        }
    }
}
