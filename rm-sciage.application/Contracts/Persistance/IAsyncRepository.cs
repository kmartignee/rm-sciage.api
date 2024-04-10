using Ardalis.Specification;
using rm_sciage.domain.Entities;

namespace rm_sciage.application.Contracts.Persistance;

public interface IAsyncRepository<T> where T : IEntity
{
    Task<bool> Exists(Guid id);
    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<T>> ListAllAsync(CancellationToken cancellationToken = default);
    Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec, CancellationToken cancellationToken = default);
    IReadOnlyList<T> List(ISpecification<T> spec);
    Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
    Task<List<T>> AddAsync(List<T> entities, CancellationToken cancellationToken = default);
    Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
    Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
    Task DeleteAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);
    Task<int> CountAsync(ISpecification<T> spec, CancellationToken cancellationToken = default);
    Task<T> FirstAsync(ISpecification<T> spec, CancellationToken cancellationToken = default);
    Task<T?> FirstOrDefaultAsync(ISpecification<T> spec, CancellationToken cancellationToken = default);
    T? FirstOrDefault(ISpecification<T> spec);
    IQueryable<T> GetAll();
    IQueryable<T> GetAll(ISpecification<T> spec);
}