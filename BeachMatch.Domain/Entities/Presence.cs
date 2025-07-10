namespace BeachMatch.Domain.Entities;

public class Presence
{
    public Guid Id { get; private set; }
    public Guid PlayerId { get; private set; }
    public Guid MatchId { get; private set; }
    public DateTime ConfirmedAt { get; private set; }

    public Presence(Guid playerId, Guid matchId)
    {
        Id = Guid.NewGuid();
        PlayerId = playerId;
        MatchId = matchId;
        ConfirmedAt = DateTime.UtcNow;
    }
}
