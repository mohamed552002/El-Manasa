using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.UserEntitiesConfiguration
{
    public class UserRoleConfiguration : BaseConfiguration<UserRoles>
    {
        public override void Configure(EntityTypeBuilder<UserRoles> builder)
        {
            base.Configure(builder);
            builder
           .HasIndex(x => new { x.RoleId, x.UserId })
           .IsUnique()
           .HasFilter("[IsDeleted] = 0");
        }
    }
}
