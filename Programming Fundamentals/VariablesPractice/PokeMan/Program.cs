using System;

namespace PokeMan
{
    class Program
    {
        static void Main(string[] args)
        {
            long pokePower = long.Parse(Console.ReadLine());
            long originalPokePower = pokePower; 
            long distance = long.Parse(Console.ReadLine());
            long exhaustionFactor = long.Parse(Console.ReadLine());
            long pokeTarget = 0;  
            while (distance<=pokePower)
            {
                if ( originalPokePower*0.50==pokePower && exhaustionFactor!=0)
                {
                    pokePower /= exhaustionFactor;
                }
                if (distance > pokePower)
                {
                    break;
                }
                
                    pokePower -= distance;
                    pokeTarget++;
             
               
                
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeTarget);
        }
    }
}
