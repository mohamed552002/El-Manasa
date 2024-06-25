using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.CourseEntitesConfiguration
{
    public class CourseConfiguration : BaseConfiguration<Course>
    {
        public override void Configure(EntityTypeBuilder<Course> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Name).HasMaxLength(64);
            builder.Property(c => c.Description).HasMaxLength(512);
        }
    }
}
