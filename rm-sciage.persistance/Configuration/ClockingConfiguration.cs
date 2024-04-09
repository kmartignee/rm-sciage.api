using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rm_sciage.domain.Entities.Pointing;

namespace rm_sciage.persistance.Configuration;

public class ClockingConfiguration : IEntityTypeConfiguration<ClockingEntity>
{
    public void Configure(EntityTypeBuilder<ClockingEntity> builder)
    {
        builder.ToTable("RMS_T_CLOCKING_CLK");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("CLK_ID");
        builder.Property(e => e.IsAm).HasColumnName("CLK_IS_AM");
        builder.Property(e => e.ArrivalTime).HasColumnName("CLK_ARRIVAL_TIME");
        builder.Property(e => e.DepartureTime).HasColumnName("CLK_DEPARTURE_TIME");
        builder.Property(e => e.PointingId).HasColumnName("CLK_POINTING_ID");
        builder.Property(e => e.CreatedDate).ValueGeneratedOnAdd().HasColumnName("CLK_CREATED_DATE");
        builder.Property(e => e.LastModifiedDate).ValueGeneratedOnUpdate().HasColumnName("CLK_LAST_MODIFIED_DATE");
    }
}