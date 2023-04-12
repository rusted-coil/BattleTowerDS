namespace BattleTowerDSDataLib.Pokemon
{
    public static class PokemonFactory
    {
        public static IPokemon Create(string name, string item, string nature, string effort, string move1, string move2, string move3, string move4)
        {
            return new Pokemon(name, item, nature, effort, move1, move2, move3, move4);
        }
    }
}
