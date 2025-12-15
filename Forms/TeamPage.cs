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
            pokeball = new Bitmap("Pokeball.png");
            emptyPokeball = new Bitmap("EmptyPokeball.png");
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
            // Testing example using MessageBox
            if (team.GetTeam().Count == 0)
            {
                MessageBox.Show("Your team is empty! There are no Pokemon to remove.", "No Pokemon to Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            RemoveFromTeam removeFromTeam = new RemoveFromTeam(team);
            removeFromTeam.ShowDialog();

            this.Activate();
            this.Show();
        }
        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (team.GetTeam().Count == 6)
            {
                MessageBox.Show("Your team is full! Remove a Pokemon before trying again.", "Team Full!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Hide();
            PokemonPage pokemonPage = new PokemonPage(team);
            pokemonPage.ShowDialog();
            this.Activate();
            this.Show();
        }

        private void TeamPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                team.SaveTeam("Team");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.ToString()} occurred while saving the team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TeamPage_Activated(object sender, EventArgs e)
        {
            flpPokemonTeam.Controls.Clear();
            pokemonPanels.Clear();
            CreatePanels();
            foreach (PokePanel panel in pokemonPanels)
            {
                flpPokemonTeam.Controls.Add(panel);
            }
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

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
