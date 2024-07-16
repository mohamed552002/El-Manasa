using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.UserEntitiesConfiguration
{
    public class SuperAdminConfiguration : IEntityTypeConfiguration<SuperAdmin>
    {
        public void Configure(EntityTypeBuilder<SuperAdmin> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User)
                .WithOne()
                .HasForeignKey<SuperAdmin>(x => x.Id);
            builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
