namespace BeachMatch.Domain.Entities;

public class Player
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Player(string name)
    {
        Name = name;
    }
}
