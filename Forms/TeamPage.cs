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
        List<Pokemon> pokemons = new List<Pokemon>();
        List<Panel> pokemonPanel = new List<Panel>();
        Image pokeball, emptyPokeball;

        // 1. Need help figuring out how to load pokemon details up into the page everytime for each control in streamlined way.
        // 2. Need help figuring out how to change the images on this and main page based on whether or not there is a pokemon in the team in that slot.
        // 3. Overall just need help figuring out how to make the program flow
        // 4. Help with Panels if possible


        // Constructor
        public TeamPage()
        {
            InitializeComponent();

        }

        // Event Handlers
        private void pnlTeamSlot_DoubleClick(object sender, EventArgs e)
        {
            Hide();

            PokemonPage pokemonPage = new PokemonPage();
            pokemonPage.ShowDialog();

            Show();
        }

        private void TeamPage_Load(object sender, EventArgs e)
        {
            List<Pokemon> pokemons = team.GetTeam();
            
        }

        // Member Functions
    }
}
