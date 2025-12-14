namespace PokemonTeamApp
{
    public class Pokedex
    {
        private List<string[]> pokedex = new List<string[]>();

        public Pokedex()
        {
            pokedex = GetPokedex();
        }

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
                MessageBox.Show("Pokedex file not found.");
                File.Create("Pokedex.txt");
            }

            return pokedex;
        }

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
