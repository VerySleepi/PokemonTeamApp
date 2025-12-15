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
        Team team;
        private bool savedChanges = true;

        // Constructor
        public PokemonPage(Team team)
        {
            InitializeComponent();
            //cbPkmnName.MaxDropDownItems = 151;
            foreach (string name in pokedex.GetAllPokemonNames())
            {
                cbPkmnName.Items.Add(name);
            }
            cbPkmnName.Visible = true;
            btnAdd.Visible = true;
            btnAdd.Enabled = true;
            this.team = team;
        }

        public PokemonPage(Pokemon pokemon, Team team)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            if (pokemon.Type2 != "")
            {
                lblType2.Visible = true;
                lblSecondaryType.Visible = true;
            }
            LoadPokemonData();
            this.team = team;
        }

        // Event Handlers
        // Raising the value changed event to adjust stats based on level changes
        private void NudLvl_ValueChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            // Preventing lblLvlValue from being empty, which happens when loading a new pokemon for the first time
            if (lblLvlValue.Text == "")
            {
                lblLvlValue.Text = nudLvl.Value.ToString();
            }

            // Retrieving the numeric updown controls from the groupbox and adjusting their values based on the adjusted levels
            if (nudLvl.Value > Convert.ToInt32(lblLvlValue.Text))
            {
                foreach (NumericUpDown stat in gBStats.Controls.OfType<NumericUpDown>())
                {
                    // Would be possible to create an algorithm that calculates stat increases based on base stats, IVs, EVs, and level, however
                    // for the sake of simplicity and time, using random values here
                    int AddToStat = rnd.Next(1, 5);
                    if (stat.TabIndex >= 2 && stat.TabIndex <= 7)
                    {
                        int statAddjustment = Convert.ToInt32(stat.Value) + AddToStat;
                        // Ensuring that the stat does not exceed the maximum value of the NumericUpDown control
                        if (statAddjustment > stat.Maximum)
                        {
                            stat.Value = stat.Maximum;
                        }
                        else
                        {
                            stat.Value = statAddjustment;
                        }
                    }
                }
                lblLvlValue.Text = nudLvl.Value.ToString();
            }
            else if (nudLvl.Value < Convert.ToInt32(lblLvlValue.Text))
            {
                foreach (NumericUpDown stat in gBStats.Controls.OfType<NumericUpDown>())
                {
                    // Instead of using random here, could consider adding a 2D array to hold the stat gain per level for the pokemon
                    // species and use that to subtract the appropriate amount
                    int SubtractStat = rnd.Next(1, 5);
                    if (stat.TabIndex >= 2 && stat.TabIndex <= 7)
                    {
                        int statAddjustment = Convert.ToInt32(stat.Value) - SubtractStat;
                        if (statAddjustment < stat.Minimum)
                        {
                            stat.Value = stat.Minimum;
                        }
                        else
                        {
                            stat.Value = statAddjustment;
                        }
                    }
                }
                lblLvlValue.Text = nudLvl.Value.ToString();
            }
            else
            {
                return;
            }
           


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

            SavePokemonData();
            team.SaveTeam("Team");
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbPkmnName.SelectedItem == null)
            {
                MessageBox.Show("Please select a Pokémon from the dropdown list.");
                return;
            }

            List<string> pokedexEntry = pokedex.SearchPokedex(cbPkmnName.SelectedItem.ToString());
            pokemon.Name = pokedexEntry[0];
            pokemon.Type1 = pokedexEntry[1];
            if (pokedexEntry.Count > 2)
            {
                pokemon.Type2 = pokedexEntry[2];
            }
            else
            {
                pokemon.Type2 = "";
            }

            SavePokemonData();
            team.AddPokemon(pokemon);
            MessageBox.Show("Pokemon added to team.", "Pokemon Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            team.SaveTeam("Team");
            this.Close();
        }

        private void PokemonPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "You have unsaved changes. Are you sure you want to exit?";
            string title = "Unsaved Changes";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (savedChanges == false)
            {
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Stat_ValueChanged(object sender, EventArgs e)
        {
            savedChanges = false;
        }

        private void cbPkmnName_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> pokedexEntry = pokedex.SearchPokedex(cbPkmnName.SelectedItem.ToString());
            if (pokedexEntry.Count == 0)
            {
                MessageBox.Show("Pokémon not found in the Pokédex.");
                cbPkmnName.SelectedIndex = -1;
                return;
            }
            lblName.Text = pokedexEntry[0];
            lblPrimaryType.Text = pokedexEntry[1];
            if (pokedexEntry.Count > 2)
            {
                lblType2.Visible = true;
                lblSecondaryType.Visible = true;
                lblSecondaryType.Text = pokedexEntry[2];
            }
            else
            {
                lblType2.Visible = false;
                lblSecondaryType.Visible = false;
            }
            lblLvlValue.Text = nudLvl.Value.ToString();
            savedChanges = false;
        }

        // Member Functions
        public void LoadPokemonData()
        {
            lblName.Text = pokemon.Name;
            lblPrimaryType.Text = pokemon.Type1;
            lblLvlValue.Text = pokemon.Level.ToString();
            nudLvl.Value = pokemon.Level;
            nudHP.Value = pokemon.HP;
            nudAtk.Value = pokemon.Attack;
            nudDef.Value = pokemon.Defense;
            nudSpAtk.Value = pokemon.SpAtk;
            nudSpDef.Value = pokemon.SpDef;
            nudSpd.Value = pokemon.Spd;

            if (pokemon.Type2 != "")
            {
                lblSecondaryType.Text = pokemon.Type2;
            }
            else
            {
                lblType2.Visible = false;
                lblSecondaryType.Visible = false;
            }

            savedChanges = true;
        }

        public void SavePokemonData()
        {
            pokemon.Name = lblName.Text;
            pokemon.Level = Convert.ToInt32(nudLvl.Value);
            pokemon.HP = Convert.ToInt32(nudHP.Value);
            pokemon.Attack = Convert.ToInt32(nudAtk.Value);
            pokemon.Defense = Convert.ToInt32(nudDef.Value);
            pokemon.SpAtk = Convert.ToInt32(nudSpAtk.Value);
            pokemon.SpDef = Convert.ToInt32(nudSpDef.Value);
            pokemon.Spd = Convert.ToInt32(nudSpd.Value);

            savedChanges = true;
        }

    }
}
