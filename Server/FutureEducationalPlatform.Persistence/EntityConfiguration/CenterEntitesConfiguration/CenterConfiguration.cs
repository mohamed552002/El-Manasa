using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.CenterEntitesConfiguration
{
    public class CenterConfiguration : BaseConfiguration<Center>
    {
        public override void Configure(EntityTypeBuilder<Center> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Name).HasMaxLength(64);
            builder.Property(c => c.Address).HasMaxLength(128);
        }
    }
}
