using BattleTowerDSDataLib.Pokemon;
using BattleTowerDSDataLib.Trainer;

namespace BattleTowerDS.Trainer
{
    static class TrainerLoader
    {
        public static IEnumerable<ITrainer> LoadTrainers(string path, IReadOnlyDictionary<int, IPokemon> pokemons)
        {
            List<ITrainer> trainers = new List<ITrainer>();

            using (StreamReader sr = new StreamReader(path))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    int nameIndex = str.IndexOf("<dt");
                    if (nameIndex != 0)
                    {
                        break;
                    }

                    string nameBlock = str.Substring(nameIndex + 4, str.IndexOf("</dt") - 4);
                    string[] nameElements = nameBlock.Split(' ');

                    int pokemonBlockStart = str.IndexOf("<dd") + 4;
                    string pokemonBlock = str.Substring(pokemonBlockStart, str.IndexOf("</dd") - pokemonBlockStart);
                    string[] pokemonIds = pokemonBlock.Split(' ');

                    trainers.Add(TrainerFactory.Create(nameElements[0], nameElements[1], pokemonIds.Select(id => pokemons[int.Parse(id)])));
                }
            }

            return trainers;
        }
    }
}
