using FutureEducationalPlatform.Domain.Entities.ComprehensiveExamEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.ComprehensiveExamEntities
{
    public class ComprehensiveExamConfiguration : BaseConfiguration<ComprehensiveExam>
    {
        public override void Configure(EntityTypeBuilder<ComprehensiveExam> builder)
        {
            base.Configure(builder);
            builder.Property(ch => ch.Name).HasMaxLength(128);
            builder.Property(ch => ch.IsActive).HasDefaultValue(true);
            builder.HasOne(ch => ch.Course)
                .WithMany()
                .HasForeignKey(ch => ch.CourseId);
        }
    }
}
