using System.Collections.ObjectModel;
using System.Diagnostics;

public class Team
{
    // Data
    private List<Pokemon> pokemonTeam = new List<Pokemon>();


    // Constructor
    public Team()
    {
        TestingTeamFunctions();
        GetTeam();
    }

    // Methods
    // Saving team to file passed in as fileName
    public void SaveTeam(string fileName)
    {
        try
        {
            List<string> pokeman = new List<string>();
            foreach (Pokemon p in pokemonTeam)
            {
                pokeman.Add(p.FormattedPokemon());
            }

            File.WriteAllLines(fileName, pokeman);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return;
        }
    }

    // Getting the current team, loading from file if not already loaded
    public List<Pokemon> GetTeam()
    {
        if (pokemonTeam.Count == 0)
        {
            LoadTeam();
        }
        return pokemonTeam;
    }

    // Loading team from file, returns list of Pokemon. For this implementation, file name is hardcoded as "Team".
    public List<Pokemon> LoadTeam()
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
        return pokemonTeam;
    }

    public Pokemon GetPokemon(int index)
    {
        if (index > pokemonTeam.Count - 1 || index == -1)
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
        try
        {
            pokemonTeam.Add(newPokemon);
        }
        catch
        {
            Debug.WriteLine("Failed to add new Pokemon to team.", "Addition Error");
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
            Debug.WriteLine("Invalid index selected for removal.", "Removal Error");
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

    // Basic testing of main Team and Pokemon class functions
    private void TestingTeamFunctions()
    {
        Pokemon testPokemon = new Pokemon("Pikachu", "Electric", 50, 150, 100, 80, 90, 70, 120);
        string pokemonInfo = testPokemon.FormattedPokemon();
        Debug.Assert(pokemonInfo == "Pikachu,Electric,50,150,100,80,90,70,120", "FormattedPokemon method failed.");

        this.AddPokemon(testPokemon);
        Debug.Assert(this.pokemonTeam[0] == testPokemon, "AddPokemon method failed.");

        List<Pokemon> testGetTeam = this.GetTeam();
        Debug.Assert(testGetTeam.Count == 1, "GetTeam method failed.");

        this.RemovePokemon(0);
        Debug.Assert(this.pokemonTeam.Count == 0, "RemovePokemon method failed.");
    }
}
