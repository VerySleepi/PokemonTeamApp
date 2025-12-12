using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonTeamApp.Forms
{
    public partial class PokemonPage : Form
    {
        // Data
        Pokemon pokemon = new Pokemon();
        Pokedex pokedex = new Pokedex();

        // Constructor
        public PokemonPage()
        {
            InitializeComponent();
            cbPkmnName.MaxDropDownItems = 151;
            cbPkmnName.Items.AddRange(pokedex.GetAllPokemonNames());
            cbPkmnName.Visible = true;
        }

        public PokemonPage(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            LoadPokemonData();
        }

        // Event Handlers
        private void NudLvl_ValueChanged(object sender, EventArgs e)
        {
            lblLvlValue.Text = nudLvl.Value.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Setting up variables for Message Box to confirm saving changes
            string message = "Save changes to " + lblName.Text + "?";
            string title = "Save Changes";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            
            if (result == DialogResult.No)
            {
                return;
            }
            
            pokemon.Name = lblName.Text;
            pokemon.Level = Convert.ToInt32(nudLvl.Value);
            pokemon.HP = Convert.ToInt32(nudHP.Value);
            pokemon.Attack = Convert.ToInt32(nudAtk.Value);
            pokemon.Defense = Convert.ToInt32(nudDef.Value);
            pokemon.SpAtk = Convert.ToInt32(nudSpAtk.Value);
            pokemon.SpDef = Convert.ToInt32(nudSpDef.Value);
            pokemon.Spd = Convert.ToInt32(nudSpd.Value);
            this.Close();
        }

        // Member Functions
        public void LoadPokemonData()
        {
            lblName.Text = pokemon.Name;
            //lblType1.Text = pokemon.Type1;
            //lblType2.Text = pokemon.Type2;
            lblLvlValue.Text = pokemon.Level.ToString();
            nudHP.Value = pokemon.HP;
            nudAtk.Value = pokemon.Attack;
            nudDef.Value = pokemon.Defense;
            nudSpAtk.Value = pokemon.SpAtk;
            nudSpDef.Value = pokemon.SpDef;
            nudSpd.Value = pokemon.Spd;
        }
    }
}
