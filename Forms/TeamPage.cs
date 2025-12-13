using PokemonTeamApp.Forms;
using PokemonTeamApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Load();
        }

        private void Load()
        {
            pokeball = new Bitmap("C:\\Users\\georg\\source\\repos\\VerySleepi\\PokemonTeamApp\\Resources\\Pokeball.png");
            emptyPokeball = new Bitmap("C:\\Users\\georg\\source\\repos\\VerySleepi\\PokemonTeamApp\\Resources\\EmptyPokeball.png");
            CreatePanels();
            foreach (PokePanel panel in pokemonPanels)
            {
                flpPokemonTeam.Controls.Add(panel);
            }


            //// TODO: Figure out getting bitmap images from resources file
            //pokeball = Resources.Pokeball;
            //emptyPokeball = Resources.EmptyPokeball;
        }

        // Event Handlers
        private void PokePanel_Click(object sender, EventArgs e)
        {
            PokePanel panel = (PokePanel)sender;
            int currentPanel = flpPokemonTeam.Controls.IndexOf(panel);
            if (currentPanel != -1 && team.GetPokemon(currentPanel) != null)
            {
                this.Hide();
                PokemonPage pokemonPage = new PokemonPage(team.GetPokemon(currentPanel));
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
            this.Close();
            RemoveFromTeam removeFromTeam = new RemoveFromTeam();
            removeFromTeam.ShowDialog();
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

    }
}
