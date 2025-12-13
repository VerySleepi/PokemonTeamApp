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
    public partial class RemoveFromTeam : Form
    {
        Team team = new Team();
        public RemoveFromTeam()
        {
            InitializeComponent();
            foreach(Pokemon p in team.GetTeam())
            {
                lbTeamList.Items.Add(p.Name);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbTeamList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Pokémon to remove from your team.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string message = "Are you sure you want to remove " + lbTeamList.SelectedItem.ToString() + " from your team?";
            string title = "Remove Pokémon";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {
                return;
            }
            team.RemovePokemon(lbTeamList.SelectedIndex);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
