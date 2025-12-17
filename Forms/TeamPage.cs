using PokemonTeamApp.Forms;

namespace PokemonTeamApp
{
    public partial class TeamPage : Form
    {
        // Data
        // Declaring team here instead of in each form to maintain team consistency across forms
        // If multple teams are implemented in the future, this would be added to another class to manage multiple teams
        // and passed as a parameter to each form where needed
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

        // Event handler for clicking on a PokePanel to open the corresponding PokemonPage
        private void PokePanel_Click(object sender, EventArgs e)
        {
            // Cast sender type to PokePanel to identify which panel was clicked
            PokePanel panel = (PokePanel)sender;
            // Accessing the control collection of the FlowLayoutPanel to get index of clicked panel
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

        // Add and Remove Pokemon button event handlers
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
            // Example of using Messagebox to provide feedback to user as well as checking team size before adding
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

        // Form Closing event to save the team data to the file
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

        // Activated event to refresh the team display when returning to this form
        // On Load would only run once when the form is first opened, which would not update the display after Pokemon are added/removed
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

        // Back to Main Menu button event handler
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Member functions

        // Function to create PokePanels for each filled team slot
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



    }
}
