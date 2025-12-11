using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokemonTeamApp
{
    public class Pokedex
    {
        private List<string[]> pokedex = new List<string[]>();

        public Pokedex()
        {

        }

        private List<string[]> GetPokedex()
        {
            List<string[]> pokedex = new List<string[]>();
            if (File.Exists("Pokedex"))
            {
                List<string> pokemonEntries = File.ReadAllLines("Pokedex").ToList();
                foreach (string pokemon in pokemonEntries)
                {
                    string[] values = pokemon.Split(',');
                    pokedex.Add(values);
                }
            }
            else
            {

            }

            return pokedex;
        }

        //public bool SearchPokedex(string name)
        //{
        //    bool validPokemon = true;
        //    while (validPokemon)
        //    {
        //        foreach (string[] pokemon in pokedex)
        //        {
        //            if (pokemon[0] != name)
        //            {
        //                validPokemon = false;
        //            }
        //            else
        //            {
        //                name = pokemon[0];
        //                if (pokemon.Length > 2)
        //                {
        //                    type1 = pokemon[1];
        //                    type2 = pokemon[2];
        //                }
        //                else
        //                {
        //                    type1 = pokemon[1];
        //                }
        //            }
        //        }
        //    }

        //    return string[name, type1, type2];
        //}

    }
}
