using BattleTowerDSDataLib.Pokemon;

namespace BattleTowerDS.Pokemon
{
    static class PokemonLoader
    {
        /// <summary>
        /// CSVファイルからデータを読み込みます。
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static IReadOnlyDictionary<int, IPokemon> LoadPokemons(string path)
        {
            Dictionary<int, IPokemon> pokemons = new Dictionary<int, IPokemon>();

            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] elements = str.Split(',');
                    if (elements.Length <= 1)
                    {
                        break;
                    }

                    int id = int.Parse(elements[0]);
                    pokemons.Add(id, PokemonFactory.Create(elements[1], elements[6], elements[7], elements[8], elements[2], elements[3], elements[4], elements[5]));
                }
            }

            return pokemons;
        }
    }
}
