namespace BeachMatch.Domain.Entities;

public class Team
{
    public Guid Id { get; private set; }
    public Guid MatchId { get; private set; }
    public Guid Player1Id { get; private set; }
    public Guid Player2Id { get; private set; }

    public Team(Guid player1Id, Guid player2Id)
    {
        Id = Guid.NewGuid();
        Player1Id = player1Id;
        Player2Id = player2Id;
    }
}
