using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.CenterEntitesConfiguration
{
    public class CenterCourseTimeConfiguration : BaseConfiguration<CenterCourseTime>
    {
        public override void Configure(EntityTypeBuilder<CenterCourseTime> builder)
        {
            base.Configure(builder);
            builder
            .HasIndex(cct => new { cct.CenterId, cct.CourseId })
            .IsUnique()
            .HasFilter("[IsDeleted] = 0");
        }
    }
}
