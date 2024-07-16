using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.HomeworkEntitesConfiguration
{
    public class HomeworkConfiguration : BaseConfiguration<Homework>
    {
        public override void Configure(EntityTypeBuilder<Homework> builder)
        {
            base.Configure(builder);
            builder.Property(h => h.IsActive).HasDefaultValue(true);
            builder.Property(h => h.Name).HasMaxLength(128);
        }
    }
}
