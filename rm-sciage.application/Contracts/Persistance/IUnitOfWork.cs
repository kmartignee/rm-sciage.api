using rm_sciage.domain.Entities.Pointing;
using rm_sciage.domain.Entities.Site;
using rm_sciage.domain.Entities.User;

namespace rm_sciage.application.Contracts.Persistance;

public interface IUnitOfWork : IDisposable
{
    IAsyncRepository<UserEntity> UserRepository { get; }
    IAsyncRepository<SiteEntity> SiteRepository { get; }
    IAsyncRepository<PointingEntity> PointingRepository { get; }

    Task SaveAsync();
}