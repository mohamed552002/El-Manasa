using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.UserEntitiesConfiguration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User)
                .WithOne()
                .HasForeignKey<Student>(x => x.Id);
            builder.Property(x => x.Address)
                .HasMaxLength(128);
            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(11);
            builder.HasOne(s=>s.Parent)
                .WithMany(p=>p.Students)
                .HasForeignKey(s => s.ParentId);
            builder.HasQueryFilter(s => !s.IsDeleted);
        }
    }
}
