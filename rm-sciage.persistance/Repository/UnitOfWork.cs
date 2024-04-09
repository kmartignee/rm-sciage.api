using rm_sciage.application.Contracts.Persistance;
using rm_sciage.domain.Entities.Pointing;
using rm_sciage.domain.Entities.Site;
using rm_sciage.domain.Entities.User;

namespace rm_sciage.persistance.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly RmsciageDbContext _context;
    
    public UnitOfWork(RmsciageDbContext context)
    {
        _context = context;
        UserRepository = new AsyncRepository<UserEntity>(_context);
        SiteRepository = new AsyncRepository<SiteEntity>(_context);
        PointingRepository = new AsyncRepository<PointingEntity>(_context);
    }

    public IAsyncRepository<UserEntity> UserRepository { get; }
    public IAsyncRepository<SiteEntity> SiteRepository { get; }
    public IAsyncRepository<PointingEntity> PointingRepository { get; }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }

    void IDisposable.Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    protected virtual void Dispose(bool disposing)
    {
        _context.Dispose();
    }
}