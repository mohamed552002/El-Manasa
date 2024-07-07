using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

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
