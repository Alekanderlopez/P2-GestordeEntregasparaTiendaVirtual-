using Gestordeentrega.Domain.Core;
using Gestordeentrega.Domain.Repository;
using Gestordeentrega.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Gestordeentrega.Infrastructure.Core;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseEntity
{
    protected readonly GestorContext _context;

    protected BaseRepository(GestorContext context) => _context = context;

    public virtual async Task<List<TEntity>> GetAllAsync() =>
        await _context.Set<TEntity>().AsNoTracking().ToListAsync();

    public virtual async Task<TEntity?> GetByIdAsync(int id) =>
        await _context.Set<TEntity>().FindAsync(id);

    public virtual async Task<TEntity> AddAsync(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task UpdateAsync(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity is null) return;
        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}