
// Pokemon class created to represent an individual Pokemon and its attributes
// which can be added to a List Collection in the Team class.
public class Pokemon
{

    // Data
    // TODO: C# Properties research w/ validation
    private string name = "";
    private string type1 = "";
    private string type2 = "";
    private int level = 1;
    private int hp = 1;
    private int attack = 1;
    private int defense = 1;
    private int spAtk = 1;
    private int spDef = 1;
    private int spd = 1;

    public string Name
    {
        // get keyword defines accessor method that returns the name value
        get { return name; }
        // set accessor same as method that returns void and takes implicit parameter 'value'
        // When value is assigned to Name property, this set accessor is invoked
        set { name = value; }
    }
    public string Type1
    {
        get { return type1; }
        set { type1 = value; }
    }

    public string Type2
    {
        get { return type2; }
        set { type2 = value; }
    }

    public int Level
    {
        get { return level; }
        set { level = value; }
    }
    public int HP
    {
        get { return hp; }
        set { hp = value; }
    }
    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }
    public int Defense
    {
        get { return defense; }
        set { defense = value; }
    }
    public int SpAtk
    {
        get { return spAtk; }
        set { spAtk = value; }
    }
    public int SpDef
    {
        get { return spDef; }
        set { spDef = value; }
    }
    public int Spd
    {
        get { return spd; }
        set { spd = value; }
    }

    // Member Constructors
    public Pokemon(string species, string type1, string type2, int lvl, int hp, int atk, int def, int spak, int spdf, int spd)
    {
        Name = species;
        Type1 = type1;
        Type2 = type2;
        Level = lvl;
        HP = hp;
        Attack = atk;
        Defense = def;
        SpAtk = spak;
        SpDef = spdf;
        Spd = spd;
    }

    public Pokemon(string species, string type1, int lvl, int hp, int atk, int def, int spak, int spdf, int spd)
    {
        Name = species;
        Type1 = type1;
        Level = lvl;
        HP = hp;
        Attack = atk;
        Defense = def;
        SpAtk = spak;
        SpDef = spdf;
        Spd = spd;
    }

    public Pokemon()
    {

    }

    // Member functions
    // Formats the Pokemon data into a comma-separated string for saving to file
    public string FormattedPokemon()
    {
        if (Type2 != "")
        {
            return $"{Name},{Type1},{Type2},{Level},{HP},{Attack},{Defense},{SpAtk},{SpDef},{Spd}";
        }
        else
        {
            return $"{Name},{Type1},{Level},{HP},{Attack},{Defense},{SpAtk},{SpDef},{Spd}";
        }
    }

    // Provides a brief overview of the Pokemon's stats
    public string StatOverview()
    {
        return $"{Name}, Lvl:{Level},\n{HP}/{HP}";
    }

    public override string ToString()
    {
        return StatOverview();
    }
}