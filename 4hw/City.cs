class City
{
    private string name;
    private int population;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Population
    {
        get { return population; }
        set { population = value >= 0 ? value : 0; }
    }

    public City(string name, int population)
    {
        this.name = name;
        this.population = population >= 0 ? population : 0;
    }

    public static City operator +(City city, int increase)
    {
        city.Population += increase;
        return city;
    }

    public static City operator -(City city, int decrease)
    {
        city.Population -= decrease;
        return city;
    }

    public static bool operator ==(City city1, City city2)
    {
        return city1.Population == city2.Population;
    }

    public static bool operator !=(City city1, City city2)
    {
        return city1.Population != city2.Population;
    }

    public static bool operator >(City city1, City city2)
    {
        return city1.Population > city2.Population;
    }

    public static bool operator <(City city1, City city2)
    {
        return city1.Population < city2.Population;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is City))
        {
            return false;
        }

        City city = (City)obj;
        return this.Population == city.Population;
    }
}