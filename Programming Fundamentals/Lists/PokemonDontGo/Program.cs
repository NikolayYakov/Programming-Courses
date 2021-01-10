using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonDistance = Console.ReadLine()
                                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                               .Select(int.Parse)
                                               .ToList();
            int sum = 0;
            while (pokemonDistance.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index > pokemonDistance.Count - 1)
                {
                    index = pokemonDistance.Count - 1;
                    sum += pokemonDistance[pokemonDistance.Count - 1];
                    for (int i = 0; i < pokemonDistance.Count; i++)
                    {
                        if (i != index)
                        {
                            if (pokemonDistance[pokemonDistance.Count-1] >= pokemonDistance[i])
                            {
                                pokemonDistance[i] += pokemonDistance[pokemonDistance.Count-1];

                            }
                            else if (pokemonDistance[pokemonDistance.Count-1] < pokemonDistance[i])
                            {
                                pokemonDistance[i] -= pokemonDistance[pokemonDistance.Count-1];
                            }
                        }

                    }
                    pokemonDistance.RemoveAt(pokemonDistance.Count - 1);
                    pokemonDistance.Add(pokemonDistance[0]);
                }
                else if (index < 0)
                {
                    index = 0;
                    sum += pokemonDistance[0];
                    for (int i = 0; i < pokemonDistance.Count; i++)
                    {
                        if (i != index)
                        {
                            if (pokemonDistance[0] >= pokemonDistance[i])
                            {
                                pokemonDistance[i] += pokemonDistance[0];

                            }
                            else if (pokemonDistance[index] < pokemonDistance[i])
                            {
                                pokemonDistance[i] -= pokemonDistance[0];
                            }
                        }

                    }
                    pokemonDistance.RemoveAt(0);
                    pokemonDistance.Insert(0, pokemonDistance[pokemonDistance.Count - 1]);
                }
                else
                {
                    for (int i = 0; i < pokemonDistance.Count; i++)
                    {
                        if (i != index)
                        {
                            if (pokemonDistance[index] >= pokemonDistance[i])
                            {
                                pokemonDistance[i] += pokemonDistance[index];

                            }
                            else if (pokemonDistance[index] < pokemonDistance[i])
                            {
                                pokemonDistance[i] -= pokemonDistance[index];
                            }
                        }

                    }
                    sum += pokemonDistance[index];
                    pokemonDistance.RemoveAt(index);
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
