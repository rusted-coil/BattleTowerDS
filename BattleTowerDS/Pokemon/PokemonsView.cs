using BattleTowerDSDataLib.Pokemon;

namespace BattleTowerDS.Pokemon
{
    class PokemonsView
    {
        DataGridView DataGridView { get; }
        BindingSource BindingSource { get; }

        class ColumnInfo
        {
            public string Key { get; set; }
            public string Text { get; set; }
            public int Width { get; set; }
        };

        public PokemonsView(DataGridView dataGridView, BindingSource bindingSource)
        {
            DataGridView = dataGridView;
            BindingSource = bindingSource;

            AddColumns();
        }

        void AddColumns()
        {
            ColumnInfo[] columns = new ColumnInfo[] {
                new ColumnInfo{ Key = "Name", Text = "名前", Width = 80 },
                new ColumnInfo{ Key = "Item", Text = "持ち物", Width = 100 },
                new ColumnInfo{ Key = "Nature", Text = "性格", Width = 80 },
                new ColumnInfo{ Key = "Effort", Text = "努力値", Width = 120 },
                new ColumnInfo{ Key = "Move1", Text = "技1", Width = 100 },
                new ColumnInfo{ Key = "Move2", Text = "技2", Width = 100 },
                new ColumnInfo{ Key = "Move3", Text = "技3", Width = 100 },
                new ColumnInfo{ Key = "Move4", Text = "技4", Width = 100 },
            };

            foreach (var info in columns)
            {
                var column = new DataGridViewTextBoxColumn { Name = info.Key, HeaderText = info.Text, DataPropertyName = info.Key };
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.Width = info.Width;
                DataGridView.Columns.Add(column);
            }
        }

        public void Clear()
        {
            BindingSource.DataSource = new IPokemon[0];
        }

        public void Show(IEnumerable<IPokemon> pokemons)
        {
            BindingSource.DataSource = pokemons.Select(pokemon => new PokemonViewModel(pokemon)).ToArray();
        }
    }
}
