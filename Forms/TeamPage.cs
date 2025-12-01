using PokemonTeamApp.Forms;
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
        List<Pokepanel> pokemonPanels = new List<Pokepanel>();
        Image pokeball, emptyPokeball;

        // Constructor
        public TeamPage()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            // TODO@: delete this temporary hard coded data
            team.AddPokemon(new Pokemon("Mim", 12, 34, 345, 45, 23, 54));
            team.AddPokemon(new Pokemon("Mim", 12, 34, 345, 45, 23, 54));
            team.AddPokemon(new Pokemon("Mim", 12, 34, 345, 45, 23, 54));
            team.AddPokemon(new Pokemon("Mim", 12, 34, 345, 45, 23, 54));
            team.AddPokemon(new Pokemon("Mim", 12, 34, 345, 45, 23, 54));
            team.AddPokemon(new Pokemon("Mim", 12, 34, 345, 45, 23, 54));

            // TODO: Loop over pokemonPanels setting the values
            lblName1.Text = team.GetPokemon(0).Name;
            pokemonPanels[0].pbPokeball.Image = pokeball;


            // TODO: Figure out getting bitmap images from resources file
            //pokeball = Image.FromFile("Properties/Resources.resx");
            //emptyPokeball = Image.FromFile("EmptyPokeball.png");
        }

        // Event Handlers
        private void pnlTeamSlot_DoubleClick(object sender, EventArgs e)
        {
            Hide();

            PokemonPage pokemonPage = new PokemonPage();
            pokemonPage.ShowDialog();

            Show();
        }

        // Member functions
        private void CreatePanels()
        {
            // TODO: Do the following for each panel, so that when you update the value of a pokemonPanel, the panel gets updated. (SEE LOAD TODO)  
            Pokepanel panel = new Pokepanel();
            panel.lblName = lblName1;

            pokemonPanels.Add(panel);
        }

    }
}
