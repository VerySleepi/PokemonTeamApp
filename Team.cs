using System.Collections.ObjectModel;
using System.Diagnostics;

public class Team
{
    // Data
    private List<Pokemon> pokemonTeam = new List<Pokemon>();

    // TODO: Create GetPokemon(int index) member function

    // Constructor
    public Team()
    {
        GetTeam();
    }

    // Methods
    public void SaveTeam()
    {
        try
        {
            List<string> pokeman = new List<string>();
            foreach (Pokemon p in pokemonTeam)
            {
                pokeman.Add(p.FormattedPokemon());
            }

            File.WriteAllLines("Team", pokeman); 
        }
        catch
        {
            MessageBox.Show("An error occurred while saving the team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    //public ReadOnlyCollection<Pokemon> GetTeam()
    //{
    //    return pokemonTeam.AsReadOnly();
    //}

    public List<Pokemon> GetTeam()
    {
        if (pokemonTeam.Count == 0)
        {
            if (File.Exists("Team"))
            {
                int startIndex = 0;
                List<string> team = File.ReadAllLines("Team").ToList();
                foreach (string pokemon in team)
                {
                    List<string> values = pokemon.Split(',').ToList();
                    List<int> intValues = new List<int>();
                    int numberOfValues = values.Count;
                    if (numberOfValues == 9)
                    {
                        startIndex = 2;
                        LoadPokemonToTeam(startIndex, numberOfValues, values, intValues);
                    }
                    else if (numberOfValues == 10)
                    {
                        startIndex = 3;
                        LoadPokemonToTeam(startIndex, numberOfValues, values, intValues);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                File.Create("Team");
            }
        }
        return pokemonTeam;

    }

    public Pokemon GetPokemon(int index)
    {
        if (pokemonTeam.Count < index + 1 || index == -1)
        {
            return null;
        }
        else
        {
            return pokemonTeam[index];
        }
    }

    public void AddPokemon(Pokemon newPokemon)
    {
        if (pokemonTeam.Count < 6)
        {
            pokemonTeam.Add(newPokemon);
            SaveTeam();
        }
        else
        {
            MessageBox.Show("Team is full! Remove a Pokemon before adding a new one.", "Team Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
    }

    public void RemovePokemon(int choiceIndex)
    {

        try
        {
            pokemonTeam.RemoveAt(choiceIndex);
            SaveTeam();
            MessageBox.Show("Pokemon removed from team.", "Pokemon Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch
        {
            return;
        }
    }

    private void LoadPokemonToTeam(int startIndex, int numberOfValues, List<string> values, List<int> intValues)
    {
        for (int i = startIndex; i < numberOfValues; i++)
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

        if (numberOfValues == 9)
        {
            Pokemon p = new Pokemon(values[0], values[1], intValues[0], intValues[1], intValues[2], intValues[3], intValues[4], intValues[5], intValues[6]);
            pokemonTeam.Add(p);
        }
        else if (numberOfValues == 10)
        {
            Pokemon p = new Pokemon(values[0], values[1], values[2], intValues[0], intValues[1], intValues[2], intValues[3], intValues[4], intValues[5], intValues[6]);
            pokemonTeam.Add(p);
        }
        else
        {
            return;
        }
    }
}
