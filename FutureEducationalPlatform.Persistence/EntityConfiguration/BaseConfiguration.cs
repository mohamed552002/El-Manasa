using FutureEducationalPlatform.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T:BaseModel
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasDefaultValueSql("NEWID()").ValueGeneratedOnAdd();
            builder.HasQueryFilter(b => !b.IsDeleted);
        }
    }
}
