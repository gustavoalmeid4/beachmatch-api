using BeachMatch.Domain.Entities;
using BeachMatch.Domain.Interfaces;
using BeachMatch.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BeachMatch.Persistence.Repositories;

public class PlayerRepository : IPlayerRepository
{
    private readonly BeachMatchDbContext _context;

    public PlayerRepository(BeachMatchDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Player player)
    {
        await _context.Players.AddAsync(player);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Player>> GetAllAsync()
    {
        return await _context.Players.ToListAsync();
    }

    public async Task<Player?> GetByIdAsync(Guid id)
    {
        return await _context.Players.FindAsync(id);
    }
}