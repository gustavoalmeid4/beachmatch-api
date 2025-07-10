using BeachMatch.Domain.Entities;

namespace BeachMatch.Domain.Interfaces;

public interface IPlayerRepository
{
    Task AddAsync(Player player);
    Task<IEnumerable<Player>> GetAllAsync();
    Task<Player?> GetByIdAsync(Guid id);
}
