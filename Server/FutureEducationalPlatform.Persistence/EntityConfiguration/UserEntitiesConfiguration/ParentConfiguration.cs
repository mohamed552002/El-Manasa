using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.UserEntitiesConfiguration
{
    public class ParentConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
           builder.HasKey(p => p.Id);
           builder.HasOne(p => p.User)
                 .WithOne()
                 .HasForeignKey<Parent>(p => p.Id);
            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(11);
            builder.HasQueryFilter(p => !p.IsDeleted);
        }
    }
}
