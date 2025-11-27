public class Pokemon
{
    // TODO: ADD TEAM CLASS USING THIS CLASS

    // Data
    // TODO: C# Properties research w/ validation
    private string name = "";
    private int level = 1;
    private int hp = 1;
    private int attack = 1;
    private int defense = 1;
    private int spAtk = 1;
    private int spDef = 1;
    private int spd = 1;

    public string Name
    {
        get { return name; }
        set { name = value; }
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
    public Pokemon(string species, int hp, int atk, int def, int spak, int spdf, int spd)
    {
        Name = species;
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
    // TODO: Add functions setting individual values
    public string FormattedPokemon()
    {
        return $"{Name},{Level},{HP},{Attack},{Defense},{SpAtk},{SpDef},{Spd}";
    }

    public string StatOverview()
    {
        return $"{Name}, Lvl:{Level}\n{HP}/{HP}";
    }

    public override string ToString()
    {
        return StatOverview();
    }
}