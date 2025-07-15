using BeachMatch.Domain.Enums;

namespace BeachMatch.Domain.Entities;

public class Match
{
    public Guid Id { get; private set; }
    public DateTime ScheduledAt { get; private set; }
    public MatchStatus Status { get; private set; }
    public List<Team> Teams { get; private set; }

    public Match(DateTime scheduledAt)
    {
        Id = Guid.NewGuid();
        ScheduledAt = scheduledAt;
        Status = MatchStatus.Scheduled;
        Teams = new List<Team>();
    }

    public void AddTeam(Team team) => Teams.Add(team);
}
