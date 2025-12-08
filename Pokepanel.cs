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
    public partial class PokePanel : UserControl
    {
        public PokePanel(Image img, Pokemon p)
        {
            InitializeComponent();

            pbPokeBall.Image = img;
            lblName.Text = p.Name;
            psbHealth.Maximum = p.HP;
            psbHealth.Value = p.HP;
        }

        public PokePanel(Image img)
        {
            InitializeComponent();
            pbPokeBall.Image = img;
        }

        private void PokePanel_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You clicked on picture box {this.lblName.ToString()}");
            
        }
    }
}
