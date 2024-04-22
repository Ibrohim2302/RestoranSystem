using Domain.Abstract;

namespace Application.Interfaces;

public interface IBaseService<TEntity> where TEntity : EntityBase
{
    Task<TEntity> GetAsync(int id, CancellationToken token = default);

    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token = default);

    Task<TEntity> CreateAsync(TEntity entity, CancellationToken token = default);

    Task<bool> UpdateAsync(TEntity entity, CancellationToken token = default);

    Task<bool> DeleteAsync(int id, CancellationToken token = default);
}
