namespace PokemonTeamApp
{
    public class Pokedex
    {
        // Data
        // Use of a list of string arrays to hold the immutable base data for each Pokemon in the Pokedex
        private List<string[]> pokedex = new List<string[]>();

        // Constructor
        public Pokedex()
        {
            pokedex = GetPokedex();
        }

        // Member Functions


        // Will be used to check validity of Pokemon names when adding to team, as well as providing type information
        private List<string[]> GetPokedex()
        {
            List<string[]> pokedex = new List<string[]>();
            if (File.Exists("Pokedex.txt"))
            {
                List<string> pokemonEntries = File.ReadAllLines("Pokedex.txt").ToList();
                foreach (string pokemon in pokemonEntries)
                {
                    string[] values = pokemon.Split(',');
                    pokedex.Add(values);
                }
            }
            else
            {
                // As this process runs on initialization of the Pokedex class, using MessageBox to inform user of missing file
                MessageBox.Show("Pokedex file not found.");
                File.Create("Pokedex.txt");
            }

            return pokedex;
        }

        // Searches the Pokedex list for a given Pokemon name, returning name and type(s) if found.
        public List<string> SearchPokedex(string name)
        {
            bool found = false;
            List<string> foundPokemon = new List<string>();
            string type1 = "";
            string type2 = "";

            while (found == false)
            {
                foreach (string[] pokemon in pokedex)
                {
                    if (pokemon[0] == name)
                    {
                        name = pokemon[0];
                        type1 = pokemon[1];
                        foundPokemon.Add(name);
                        foundPokemon.Add(type1);
                        if (pokemon.Length > 2)
                        {
                            type2 = pokemon[2];
                            foundPokemon.Add(type2);
                        }
                        found = true;
                    }
                }
            }
            return foundPokemon;
        }

        // Retrieves a list of all Pokémon names in the Pokédex, to be used when selecting a Pokemon to add to the team.
        public List<string> GetAllPokemonNames()
        {
            List<string> pokemonNames = new List<string>();
            foreach (string[] pokemon in pokedex)
            {
                pokemonNames.Add(pokemon[0]);
            }
            return pokemonNames;

        }

    }
}
