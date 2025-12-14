using PokemonTeamApp.Forms;

namespace PokemonTeamApp
{
    public partial class TeamPage : Form
    {
        // Data
        Team team = new Team();
        List<PokePanel> pokemonPanels = new List<PokePanel>();
        Bitmap pokeball, emptyPokeball;

        // Constructor
        public TeamPage()
        {
            InitializeComponent();
        }

        private void TeamPage_Load(object sender, EventArgs e)
        {
            flpPokemonTeam.Controls.Clear();
            pokeball = new Bitmap("C:\\Users\\georg\\source\\repos\\VerySleepi\\PokemonTeamApp\\Resources\\Pokeball.png");
            emptyPokeball = new Bitmap("C:\\Users\\georg\\source\\repos\\VerySleepi\\PokemonTeamApp\\Resources\\EmptyPokeball.png");
            CreatePanels();
            foreach (PokePanel panel in pokemonPanels)
            {
                flpPokemonTeam.Controls.Add(panel);
            }
        }

        // Event Handlers
        private void PokePanel_Click(object sender, EventArgs e)
        {
            PokePanel panel = (PokePanel)sender;
            int currentPanel = flpPokemonTeam.Controls.IndexOf(panel);
            if (currentPanel != -1 && team.GetPokemon(currentPanel) != null)
            {
                this.Hide();
                PokemonPage pokemonPage = new PokemonPage(team.GetPokemon(currentPanel), team);
                pokemonPage.ShowDialog();
                this.Show();
            }
            else
            {
                return;
            }
        }

        private void btnRemovePokemon_Click(object sender, EventArgs e)
        {
            if (team.GetTeam().Count == 0)
            {
                MessageBox.Show("Your team is empty! There are no Pokemon to remove.", "No Pokemon to Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Hide(); 
            RemoveFromTeam removeFromTeam = new RemoveFromTeam(team);
            removeFromTeam.ShowDialog();
            this.Refresh();
            this.Show();
        }

        private void TeamPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            team.SaveTeam();
        }

        // Member functions
        private void CreatePanels()
        {
            for (int i = 0; i < 6; i++)
            {
                if (team.GetPokemon(i) != null)
                {
                    PokePanel poke = new PokePanel(pokeball, team.GetPokemon(i));
                    poke.DoubleClick += PokePanel_Click;
                    pokemonPanels.Add(poke);
                }
                else
                {
                    PokePanel poke = new PokePanel(emptyPokeball);
                    pokemonPanels.Add(poke);
                }
            }
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokemonPage pokemonPage = new PokemonPage(team);
            pokemonPage.ShowDialog();
            this.Refresh();
        }


    }
}
