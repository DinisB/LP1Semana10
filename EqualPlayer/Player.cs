public class Player
{
    public PlayerClass PClass { get; }
    public string Name { get; }

    public Player(PlayerClass pClass, string name)
    {
        PClass = pClass;
        Name = name;
    }

    public override bool Equals(object obj)
    {
        if (obj is Player other)
        {
            return this.PClass == other.PClass && this.Name == other.Name;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return PClass.GetHashCode() ^ Name.GetHashCode();
    }
}
