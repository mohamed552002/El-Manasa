using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.CourseEntitesConfiguration
{
    public class CourseSectionConfiguration:BaseConfiguration<CourseSection>
    {
        public override void Configure(EntityTypeBuilder<CourseSection> builder)
        {
            base.Configure(builder);
            builder
                .Property(cs => cs.Name)
                .HasMaxLength(64);
            builder
                .Property(cs => cs.Description)
                .HasMaxLength(512);
            builder
                .HasOne(cs => cs.Course)
                .WithMany(c=>c.Sections)
                .HasForeignKey(cs => cs.CourseId);
        }
    }
}
