namespace PokemonTeamApp
{
    public partial class MainMenu : Form
    {
        // Data
        Team team = new Team();
        List<Pokemon> pokemons = new List<Pokemon>();
        Image pokeball, emptyPokeball;

        // Constructor
        public MainMenu()
        {
            InitializeComponent();

            pokemons = team.GetTeam();
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
