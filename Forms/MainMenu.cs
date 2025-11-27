namespace PokemonTeamApp
{
    public partial class MainMenu : Form
    {
        // Data
        Team team = new Team();
        List<Pokemon> pokemons;
        Image pokeball, emptyPokeball;

        // Constructor
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            Hide();

            TeamPage Teampage = new TeamPage();
            Teampage.ShowDialog();

            Show();
        }


        // Event Handler

        // Member Functions

    }
}
