using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Tournament")
                {
                    break;
                }

                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"

                List<string> InputInfo = input
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                string trainerName = InputInfo[0];
                string pokemonName = InputInfo[1];
                string pokemonElement = InputInfo[2];
                int pokemonHealth = int.Parse(InputInfo[3]);

                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if(trainers.Any(x => x.Name == trainerName))
                {
                    for (int i = 0; i < trainers.Count; i++)
                    {
                        if(trainers[i].Name == trainerName)
                        {
                            trainers[i].Pokemons.Add(currentPokemon);
                        }
                    }
                }
                else
                {
                    trainers.Add(new Trainer(trainerName, new List<Pokemon>() { currentPokemon }));
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }


                if(command == "Fire" || command == "Water" || command == "Electricity")
                {
                    for (int i = 0; i < trainers.Count; i++)
                    {
                        if (trainers[i].Pokemons.Any(x => x.Element == command))
                        {
                            trainers[i].NumberOfBadges++;
                        }
                        else
                        {
                            for (int j = 0; j < trainers[i].Pokemons.Count; j++)
                            {
                                trainers[i].Pokemons[j].Health -= 10;

                                if (trainers[i].Pokemons[j].Health <= 0)
                                {
                                    trainers[i].Pokemons.RemoveAt(j);
                                }
                            }
                        }
                    }
                }
            }

            var sortedTrainers = trainers.OrderByDescending(x => x.NumberOfBadges);

            foreach(var trainer in sortedTrainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
