using PokemonTeamApp.Forms;

namespace PokemonTeamApp
{
    public partial class MainMenu : Form
    {
        // Possible to add multiple save slots for multiple teams in the future
        // however for now, just one team per user

        // Constructor
        public MainMenu()
        {
            InitializeComponent();
        }

        // Event Handler
        private void btnTeam_Click(object sender, EventArgs e)
        {
            Hide();

            TeamPage Teampage = new TeamPage();
            Teampage.ShowDialog();

            Show();
        }

    }
}
