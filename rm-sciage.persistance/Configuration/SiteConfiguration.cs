using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rm_sciage.domain.Entities.Site;

namespace rm_sciage.persistance.Configuration;

public class SiteConfiguration : IEntityTypeConfiguration<SiteEntity>
{
    public void Configure(EntityTypeBuilder<SiteEntity> builder)
    {
        builder.ToTable("RMS_T_SITE_STE");
        
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("STE_ID");
        builder.Property(e => e.Name).HasColumnName("STE_NAME");
        builder.Property(e => e.Description).HasColumnName("STE_DESCRIPTION");
        builder.Property(e => e.City).HasColumnName("STE_CITY");
        builder.Property(e => e.Address).HasColumnName("STE_ADDRESS");
        builder.Property(e => e.ZipCode).HasColumnName("STE_ZIP_CODE");
        builder.Property(e => e.Status).HasColumnName("STE_STATUS");
        builder.Property(e => e.CreatedDate).ValueGeneratedOnAdd().HasColumnName("STE_CREATED_DATE");
        builder.Property(e => e.LastModifiedDate).ValueGeneratedOnUpdate().HasColumnName("STE_LAST_MODIFIED_DATE");
    }
}