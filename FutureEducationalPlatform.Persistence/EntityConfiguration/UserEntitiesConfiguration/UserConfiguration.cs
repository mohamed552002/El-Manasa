using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.UserEntitiesConfiguration
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(u => u.FirstName)
                 .HasMaxLength(50);
            builder.Property(u => u.LastName)
                .HasMaxLength(50);
            builder.Property(u => u.Email)
                .HasMaxLength(50);
            builder.Property(u => u.UserName)
                .HasMaxLength(50);
            builder.HasIndex(u => u.UserName)
                .IsUnique();
            builder.Property(u => u.PasswordHash)
                .HasMaxLength(64);
            builder.Property(u => u.SecurityStamp)
                .HasMaxLength(64);
            builder.OwnsMany(u => u.RefreshTokens);
        }
    }
}
