using FutureEducationalPlatform.Domain.Entities.ExamEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.ExamEntitesConfiguration
{
    public class ExamQuestionConfiguration:BaseConfiguration<ExamQuestion>
    {
        public override void Configure(EntityTypeBuilder<ExamQuestion> builder)
        {
            base.Configure(builder);
            builder
           .HasIndex(eq => new { eq.ExamId, eq.QuestionId })
           .IsUnique()
           .HasFilter("[IsDeleted] = 0");
        }
    }
}
