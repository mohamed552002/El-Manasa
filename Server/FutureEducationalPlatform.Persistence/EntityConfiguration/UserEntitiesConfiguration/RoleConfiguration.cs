using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.UserEntitiesConfiguration
{
    public class RoleConfiguration : BaseConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).HasMaxLength(50);
        }
    }
}
