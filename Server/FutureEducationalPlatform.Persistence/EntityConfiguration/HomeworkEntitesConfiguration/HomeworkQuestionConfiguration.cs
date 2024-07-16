using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.HomeworkEntitesConfiguration
{
    public class HomeworkQuestionConfiguration : BaseConfiguration<HomeworkQuestion>
    {
        public override void Configure(EntityTypeBuilder<HomeworkQuestion> builder)
        {
            base.Configure(builder);
            builder
            .HasIndex(hq => new { hq.HomeworkId, hq.QuestionId })
            .IsUnique()
            .HasFilter("[IsDeleted] = 0");
        }
    }
}
