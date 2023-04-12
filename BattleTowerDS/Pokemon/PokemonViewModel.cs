using BattleTowerDSDataLib.Pokemon;

namespace BattleTowerDS.Pokemon
{
    class PokemonViewModel
    {
        public string Name { get; }
        public string Item { get; }
        public string Nature { get; }
        public string Effort { get; }
        public string Move1 { get; }
        public string Move2 { get; }
        public string Move3 { get; }
        public string Move4 { get; }

        public PokemonViewModel(IPokemon pokemon)
        {
            Name = pokemon.Name;
            Item = pokemon.Item;
            Nature = pokemon.Nature;
            Effort = pokemon.Effort;
            Move1 = pokemon.Move1;
            Move2 = pokemon.Move2;
            Move3 = pokemon.Move3;
            Move4 = pokemon.Move4;
        }
    }
}
