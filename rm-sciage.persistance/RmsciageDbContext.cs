using Microsoft.EntityFrameworkCore;
using rm_sciage.domain.Entities.Pointing;
using rm_sciage.domain.Entities.Site;
using rm_sciage.domain.Entities.User;

namespace rm_sciage.persistance;

public class RmsciageDbContext : DbContext
{
    public RmsciageDbContext(DbContextOptions<RmsciageDbContext> options) : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; }
    public DbSet<SiteEntity> Sites { get; set; }
    public DbSet<PointingEntity> Pointings { get; set; }
    public DbSet<PointingSiteEntity> PointingSites { get; set; }
    public DbSet<ClockingEntity> Clockings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RmsciageDbContext).Assembly);
    }
}