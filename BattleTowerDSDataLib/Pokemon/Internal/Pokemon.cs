namespace BattleTowerDSDataLib.Pokemon
{
    internal class Pokemon : IPokemon
    {
        public string Name { get; }
        public string Item { get; }
        public string Nature { get; }
        public string Effort { get; }
        public string Move1 { get; }
        public string Move2 { get; }
        public string Move3 { get; }
        public string Move4 { get; }

        public Pokemon(string name, string item, string nature, string effort, string move1, string move2, string move3, string move4)
        {
            Name = name;
            Item = item;
            Nature = nature;
            Effort = effort;
            Move1 = move1;
            Move2 = move2;
            Move3 = move3;
            Move4 = move4;
        }
    }
}
