using BeachMatch.Domain.Entities;

namespace BeachMatch.Application.Interfaces.Services;

public interface IPlayerService
{
    Task CreatePlayerAsync(Player player);
    Task<IEnumerable<Player>> GetAllPlayersAsync();
    Task<Player> GetPlayerByIdAsync(Guid id);
}