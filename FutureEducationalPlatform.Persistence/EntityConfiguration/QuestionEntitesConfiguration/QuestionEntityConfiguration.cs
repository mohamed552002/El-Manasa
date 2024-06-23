using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.QuestionEntitesConfiguration
{
    public class QuestionEntityConfiguration : BaseConfiguration<Question>
    {
        public override void Configure(EntityTypeBuilder<Question> builder)
        {
            base.Configure(builder);
            builder.Property(q=> q.Text).HasMaxLength(512);
        }
    }
}
