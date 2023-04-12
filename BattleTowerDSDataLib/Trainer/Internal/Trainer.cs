using BattleTowerDSDataLib.Pokemon;
using System.Collections.Generic;

namespace BattleTowerDSDataLib.Trainer
{
    internal class Trainer : ITrainer
    {
        public string Class { get; }
        public string Name { get; }
        public IEnumerable<IPokemon> UsablePokemons { get; }

        public Trainer(string className, string name, IEnumerable<IPokemon> pokemons)
        {
            Class = className;
            Name = name;
            UsablePokemons = pokemons;
        }
    }
}
