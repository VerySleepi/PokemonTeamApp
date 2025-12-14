namespace PokemonTeamApp
{
    public partial class MainMenu : Form
    {
        // Data

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

        // Member Functions

    }
}
