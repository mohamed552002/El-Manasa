using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.CenterEntitesConfiguration
{
    public class CenterCourseTimeConfiguration : IEntityTypeConfiguration<CenterCourseTime>
    {
        public void Configure(EntityTypeBuilder<CenterCourseTime> builder)
        {
            builder.HasKey(cct => new {cct.CenterId, cct.CourseId});
            builder.HasQueryFilter(cct => !cct.IsDeleted);
        }
    }
}
