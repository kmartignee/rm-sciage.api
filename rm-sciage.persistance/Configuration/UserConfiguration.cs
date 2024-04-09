using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rm_sciage.domain.Entities.User;

namespace rm_sciage.persistance.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("RMS_T_USER_USR");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id).ValueGeneratedOnAdd().HasColumnName("USR_ID");
        builder.Property(u => u.LastName).HasColumnName("USR_LAST_NAME");
        builder.Property(u => u.FirstName).HasColumnName("USR_FIRST_NAME");
        builder.Property(u => u.Email).HasColumnName("USR_EMAIL");
        builder.Property(u => u.Password).HasColumnName("USR_PASSWORD");
        builder.Property(u => u.Phone).HasColumnName("USR_PHONE");
        builder.Property(u => u.BirthDate).HasColumnName("USR_BIRTH_DATE");
        builder.Property(u => u.Skills).HasColumnName("USR_SKILLS");
        builder.Property(u => u.IsAdmin).HasColumnName("USR_IS_ADMIN");
        builder.Property(u => u.CreatedDate).ValueGeneratedOnAdd().HasColumnName("USR_CREATED_DATE");
        builder.Property(u => u.LastModifiedDate).ValueGeneratedOnUpdate().HasColumnName("USR_UPDATED_DATE");
    }
}