using BeachMatch.Application.Interfaces.Services;
using BeachMatch.Domain.Entities;
using BeachMatch.Domain.Interfaces;

namespace BeachMatch.Application.Services;

public class PlayerService : IPlayerService
{
    private readonly IPlayerRepository _repository;

    public PlayerService(IPlayerRepository repository)
    {
        _repository = repository;
    }

    public async Task CreatePlayerAsync(Player player)
    {
        await _repository.AddAsync(player);
    }

    public async Task<IEnumerable<Player>> GetAllPlayersAsync()
    {
        return await _repository.GetAllAsync();
    }
    
    public async Task<Player> GetPlayerByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }
}
