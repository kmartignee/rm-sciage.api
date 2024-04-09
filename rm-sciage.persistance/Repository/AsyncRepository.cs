using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.domain.Entities;

namespace rm_sciage.persistance.Repository;

public class AsyncRepository<T> : IAsyncRepository<T> where T : class, IEntity
{
    private readonly RmsciageDbContext _dbContext;

    public AsyncRepository(RmsciageDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await _dbContext.Set<T>().AddAsync(entity, cancellationToken);

        return entity;
    }

    public async Task<List<T>> AddAsync(List<T> entities, CancellationToken cancellationToken = default)
    {
        await _dbContext.Set<T>().AddRangeAsync(entities, cancellationToken);

        return entities;
    }

    public async Task<int> CountAsync(ISpecification<T> spec, CancellationToken cancellationToken = default)
    {
        var specificationResult = ApplySpecification(spec);

        return await specificationResult.CountAsync(cancellationToken);
    }

    public async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
    {
        await Task.Run(() => { _dbContext.Set<T>().Remove(entity); }, cancellationToken);
    }
    
    public Task DeleteAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
    {
        _dbContext.Set<T>().RemoveRange(entities);

        return Task.CompletedTask;
    }

    public async Task<T> FirstAsync(ISpecification<T> spec, CancellationToken cancellationToken = default)
    {
        var specificationResult = ApplySpecification(spec);

        return await specificationResult.FirstAsync(cancellationToken);
    }

    public async Task<T?> FirstOrDefaultAsync(ISpecification<T> spec, CancellationToken cancellationToken = default)
    {
        var specificationResult = ApplySpecification(spec);

        return await specificationResult.FirstOrDefaultAsync(cancellationToken);
    }

    public T? FirstOrDefault(ISpecification<T> spec)
    {
        var specificationResult = ApplySpecification(spec);

        return specificationResult.FirstOrDefault();
    }

    public async Task<bool> Exists(int id)
    {
        var entity = await GetByIdAsync(id);

        return entity != null;
    }

    public virtual async Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var keyValues = new object[] { id };

        return await _dbContext.Set<T>().FindAsync(keyValues, cancellationToken);
    }

    public IQueryable<T> GetAll()
    {
        return _dbContext.Set<T>().AsNoTracking().AsQueryable();
    }

    public IQueryable<T> GetAll(ISpecification<T> spec)
    {
        var specificationResult = ApplySpecification(spec);

        return specificationResult.AsNoTracking().AsQueryable();
    }

    public async Task<IReadOnlyList<T>> ListAllAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext.Set<T>().ToListAsync(cancellationToken);
    }

    public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec,
        CancellationToken cancellationToken = default)
    {
        var specificationResult = ApplySpecification(spec);

        return await specificationResult.ToListAsync(cancellationToken);
    }

    public IReadOnlyList<T> List(ISpecification<T> spec)
    {
        var specificationResult = ApplySpecification(spec);

        return specificationResult.ToList();
    }

    public async Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
    {
        await Task.Run(() => { _dbContext.Entry(entity).State = EntityState.Modified; });
    }

    private IQueryable<T> ApplySpecification(ISpecification<T> spec)
    {
        var evaluator = new SpecificationEvaluator();

        return evaluator.GetQuery(_dbContext.Set<T>().AsQueryable(), spec);
    }
}