namespace BeachMatch.Domain.Entities;

public class Player
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public int SkillLevel { get; private set; }

    public Player(string name , int skillLevel)
    {
        Id = Guid.NewGuid();
        Name = name;
        SkillLevel = skillLevel;
    }
}
