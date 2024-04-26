using Microsoft.EntityFrameworkCore;
using Application.Interfaces.Repositories;
using Domain;
using Infrastructure.Persistence.DataBases;

namespace Infrastructure.Persistence.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : EntityBase
{

    private readonly EFContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public BaseRepository(EFContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public async Task<TEntity> CreateAsync(TEntity entity, CancellationToken token = default)
    {
        await _dbSet.AddAsync(entity, token);
        await _context.SaveChangesAsync(token);
        return entity;
    }

    public async Task<bool> DeleteAsync(TEntity entity, CancellationToken token = default)
    {
        _dbSet.Remove(entity);
        return await _context.SaveChangesAsync(token) > 0;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token = default)
    {
        return await _dbSet.ToListAsync(token);
    }

    public async Task<TEntity> GetAsync(int id, CancellationToken token = default)
    {
        return await _dbSet.FirstAsync(x => x.Id == id, token);
    }
    public async Task<bool> UpdateAsync(TEntity entity, CancellationToken token = default)
    {
        return await _context.SaveChangesAsync(token) > 0;
    }
}


