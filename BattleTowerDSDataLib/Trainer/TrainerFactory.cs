using System.Collections.Generic;
using BattleTowerDSDataLib.Pokemon;

namespace BattleTowerDSDataLib.Trainer
{
    public static class TrainerFactory
    {
        public static ITrainer Create(string className, string name, IEnumerable<IPokemon> pokemons)
        {
            return new Trainer(className, name, pokemons);
        }
    }
}
