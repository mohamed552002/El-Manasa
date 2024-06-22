using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.CourseEntitesConfiguration
{
    public class CourseSectionConfiguration:BaseConfiguration<CourseSection>
    {
        public override void Configure(EntityTypeBuilder<CourseSection> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Name).HasMaxLength(64);
            builder.Property(c => c.Description).HasMaxLength(512);
        }
    }
}
