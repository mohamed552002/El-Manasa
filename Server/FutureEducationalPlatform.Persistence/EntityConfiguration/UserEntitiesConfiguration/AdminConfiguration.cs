using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.UserEntitiesConfiguration
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
           builder.HasKey(a => a.Id);
           builder.HasOne(a => a.User)
                 .WithOne()
                 .HasForeignKey<Admin>(a => a.Id);
            builder.HasQueryFilter(a => !a.IsDeleted);
        }
    }
}
