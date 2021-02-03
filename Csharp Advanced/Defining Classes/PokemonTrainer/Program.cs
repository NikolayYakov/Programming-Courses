using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StratUp
    {
        static void Main(string[] args)
        {
            string[] date = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<Trainer> trainers = new List<Trainer>();
            while(date[0]!= "Tournament")
            {
                string trainerName = date[0];
                string pokemonName = date[1];
                string pokemonElement = date[2];
                int pokemonHealth = int.Parse(date[3]);
                Pokemon pokemont = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                bool isPresent = false;
                if (trainers.Count > 0)
                {
                    foreach (var train in trainers)
                    {
                        if (train.Name == trainerName)
                        {
                            isPresent = true;
                            train.Pokemons.Add(pokemont);
                            break;
                            
                        }
                    }
                }
                if(isPresent == false)
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons = new List<Pokemon>();
                    trainer.Pokemons.Add(pokemont);
                    trainers.Add(trainer);
                }
                date = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                if (trainers.Count > 0)
                {
                    for(int j =0;j<trainers.Count;j++)
                    {
                        bool isElement = false;
                        foreach (var pokemon in trainers[j].Pokemons)
                        {
                            if (pokemon.Element == command)
                            {
                                trainers[j].NumberOfBadges++;
                                isElement = true;
                                break;
                            }
                        }
                        if(isElement == false)
                        {
                            for (int i = 0; i < trainers[j].Pokemons.Count; i++)
                            {
                                trainers[j].Pokemons[i].Health -= 10;
                                if (trainers[j].Pokemons[i].Health <= 0)
                                {
                                    trainers[j].Pokemons.Remove(trainers[j].Pokemons[i]);
                                    i--;
                                }
                            }
                        }
                        
                    }
                    
                    
                }
                command = Console.ReadLine();
            }
            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
