using BattleTowerDSDataLib.Pokemon;
using BattleTowerDSDataLib.Trainer;
using BattleTowerDS.Pokemon;

namespace BattleTowerDS
{
    public partial class Form1 : Form
    {
        IReadOnlyDictionary<int, IPokemon> Pokemons { get; }
        IEnumerable<ITrainer> Trainers { get; }

        PokemonsView m_PokemonsView;

        public Form1()
        {
            Pokemons = Pokemon.PokemonLoader.LoadPokemons("bt_poke.csv");
            Trainers = Trainer.TrainerLoader.LoadTrainers("trainers.txt", Pokemons);

            InitializeComponent();

            m_PokemonsView = new PokemonsView(PokemonsView, PokemonsViewBindingSource);
        }

        void RefreshSearch()
        {
            string className = TrainerClass.Text;
            string name = TrainerName.Text;
            string pokemonName = PokemonName.Text;

            if (string.IsNullOrEmpty(className) && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(pokemonName))
            {
                m_PokemonsView.Clear();
                return;
            }

            var trainers = Trainers;
            if (!string.IsNullOrEmpty(className))
            {
                trainers = trainers.Where(trainer => trainer.Class.Contains(className));
            }
            if (!string.IsNullOrEmpty(name))
            {
                // –¼‘O‚ÍŠ®‘Sˆê’v
                trainers = trainers.Where(trainer => trainer.Name.Equals(name));
            }
            var pokemons = trainers.SelectMany(trainer => trainer.UsablePokemons);
            if (!string.IsNullOrEmpty(pokemonName))
            {
                pokemons = pokemons.Where(pokemon => pokemon.Name.Contains(pokemonName));
            }

            m_PokemonsView.Show(pokemons.Distinct());
        }

        private void TrainerClass_TextChanged(object sender, EventArgs e) => RefreshSearch();
        private void TrainerName_TextChanged(object sender, EventArgs e) => RefreshSearch();
        private void PokemonName_TextChanged(object sender, EventArgs e) => RefreshSearch();

        private void TrainerClass_Enter(object sender, EventArgs e) => TrainerClass.SelectAll();
        private void TrainerName_Enter(object sender, EventArgs e) => TrainerName.SelectAll();
        private void PokemonName_Enter(object sender, EventArgs e) => PokemonName.SelectAll();
    }
}