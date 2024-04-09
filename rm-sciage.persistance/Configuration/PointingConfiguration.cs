using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rm_sciage.domain.Entities.Pointing;

namespace rm_sciage.persistance.Configuration;

public class PointingConfiguration : IEntityTypeConfiguration<PointingEntity>
{
    public void Configure(EntityTypeBuilder<PointingEntity> builder)
    {
        builder.ToTable("RMS_T_POINTING_PTG");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("PTG_ID");
        builder.Property(e => e.UserId).HasColumnName("USR_ID");
        builder.Property(e => e.Date).HasColumnName("PTG_DATE");
        builder.Property(e => e.IsDriver).HasColumnName("PTG_IS_DRIVER");
        builder.Property(e => e.Description).HasColumnName("PTG_DESCRIPTION");
        builder.Property(e => e.CreatedDate).ValueGeneratedOnAdd().HasColumnName("PTG_CREATED_DATE");
        builder.Property(e => e.LastModifiedDate).ValueGeneratedOnUpdate().HasColumnName("PTG_LAST_MODIFIED_DATE");
        
        builder.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId);
        builder.HasMany(e => e.Clockings).WithOne(e => e.Pointing).HasForeignKey(e => e.PointingId);
        builder.HasMany(e => e.Sites).WithMany(e => e.Pointings).UsingEntity<PointingSiteEntity>(
            j => j.HasOne(e => e.Site).WithMany().HasForeignKey(e => e.SiteId),
            j => j.HasOne(e => e.Pointing).WithMany().HasForeignKey(e => e.PointingId),
            j =>
            {
                j.ToTable("RMS_TR_POINTING_SITE");

                j.HasKey(e => new { e.PointingId, e.SiteId });

                j.Property(e => e.PointingId).HasColumnName("PTG_ID");
                j.Property(e => e.SiteId).HasColumnName("SITE_ID");
            });
    }
}