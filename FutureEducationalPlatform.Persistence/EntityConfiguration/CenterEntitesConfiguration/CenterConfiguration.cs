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
    public class CenterConfiguration : IEntityTypeConfiguration<Center>
    {
        public void Configure(EntityTypeBuilder<Center> builder)
        {
            builder.HasKey(c=>c.Id);
            builder.Property(c => c.Id).HasDefaultValueSql("NEWID()").ValueGeneratedOnAdd();
            builder.Property(c => c.Name).HasMaxLength(64);
            builder.Property(c => c.Address).HasMaxLength(128);
            builder.HasQueryFilter(c => !c.IsDeleted);
        }
    }
}
