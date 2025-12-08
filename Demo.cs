using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonTeamApp.Properties;

namespace PokemonTeamApp
{
    public partial class Demo : Form
    {
        int counter = 0;
        public Demo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            counter++;
            // Fix: Use Bitmap instead of Image, as Image is an abstract class
            Bitmap pokeballImage = new Bitmap("C:\\Users\\c5016395\\source\\repos\\VerySleepi\\PokemonTeamApp\\Resources\\EmptyPokeball.png");
            //PokePanel uCDemo = new PokePanel(pokeballImage, $"Pokemon - {counter}");
            //uCDemo.Padding = new System.Windows.Forms.Padding(5);
            ////uCDemo.Click += Uc_Click;
            //flpPokePanel.Controls.Add( uCDemo );

        }

        private void Uc_Click(object sender, EventArgs e)
        {
            PokePanel uCDemo1 = (PokePanel)sender;
            MessageBox.Show($"You clicked on picture box {uCDemo1.Tag.ToString()}");

        }
    }
}
