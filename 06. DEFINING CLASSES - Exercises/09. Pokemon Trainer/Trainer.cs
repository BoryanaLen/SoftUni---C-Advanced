using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }


        public Trainer(string name, List<Pokemon> pokemons)
        {
            this.Name = name;
            this.Pokemons = pokemons;
            this.NumberOfBadges = 0;
        }

    }
}
