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
            pokeball = new Bitmap("C:\\Users\\c5016395\\source\\repos\\VerySleepi\\PokemonTeamApp\\Resources\\Pokeball.png");
            emptyPokeball = new Bitmap("C:\\Users\\c5016395\\source\\repos\\VerySleepi\\PokemonTeamApp\\Resources\\EmptyPokeball.png");
            CreatePanels();
            foreach (PokePanel panel in pokemonPanels)
            {
                flbPokemonTeam.Controls.Add(panel);
            }
            
            //pokemonPanels[0].pbPokeball.Image = pokeball;


            //// TODO: Figure out getting bitmap images from resources file
            //pokeball = Resources.Pokeball;
            //emptyPokeball = Resources.EmptyPokeball;
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
            // TODO: Loop over pokemonPanels setting the values
            for (int i = 0; i < 6; i++)
            {
                if (team.GetTeam()[i] != null)
                {
                    PokePanel poke = new PokePanel(pokeball, team.GetTeam()[i]);
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
