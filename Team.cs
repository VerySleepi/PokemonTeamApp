using System.Collections.ObjectModel;

public class Team
{
    // Data
    private List<Pokemon> pokemonTeam = new List<Pokemon>();

    // ERROR: System.IO.IOException: 'The process cannot access the file 'C:\Users\Student\Documents\Code\Programming\PokemonTeamApp\bin\Debug\net9.0-windows\Team' because it is being used by another process.'

    // Constructor
    public Team()
    {
        if (File.Exists("Team"))
        {
            List<string> team = File.ReadAllLines("Team").ToList();
            foreach (string pokemon in team)
            {
                List<string> values = pokemon.Split(',').ToList();
                List<int> intValues = new List<int>();
                for (int i = 1; i < values.Count; i++)
                {
                    try
                    {
                        intValues.Add(Convert.ToInt32(values[i]));
                    }
                    catch
                    {
                        break;
                    }
                }
                Pokemon p = new Pokemon(values[0], intValues[0], intValues[1], intValues[2], intValues[3], intValues[4], intValues[5]);
                pokemonTeam.Add(p);
            }
        }
        else
        {
            File.Create("Team");
        }
    }

    // Methods
    public void SaveTeam()
    {
        List<string> pokeman = new List<string>();
        foreach (Pokemon p in pokemonTeam)
        {
            pokeman.Add(p.FormattedPokemon());
        }

        File.WriteAllLines("Team", pokeman);
    }

    //public ReadOnlyCollection<Pokemon> GetTeam()
    //{
    //    return pokemonTeam.AsReadOnly();
    //}

    public List<Pokemon> GetTeam()
    {
        return pokemonTeam;
    }

    public void AddPokemon(Pokemon newPokemon)
    {
        if (pokemonTeam.Count < 6)
        {
            pokemonTeam.Add(newPokemon);
        }
        else
        {
            return;
        }
    }

    public void RemovePokemon(int choiceIndex)
    {
        try
        {
            pokemonTeam.RemoveAt(choiceIndex);
        }
        catch
        {

        }
    }
}
