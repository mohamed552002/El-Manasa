using FutureEducationalPlatform.Domain.Entities.ExamEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.ExamEntitesConfiguration
{
    public class ExamConfiguration:BaseConfiguration<Exam>
    {
        public override void Configure(EntityTypeBuilder<Exam> builder)
        {
            base.Configure(builder);
            builder.Property(e=> e.Name).HasMaxLength(128);
        }
    }
}
