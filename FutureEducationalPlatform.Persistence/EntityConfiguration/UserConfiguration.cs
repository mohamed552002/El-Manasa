using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FutureEducationalPlatform.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutureEducationalPlatform.Domain.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id)
              .HasDefaultValueSql("NEWID()")
              .ValueGeneratedOnAdd();
            builder.Property(u => u.FirstName)
                 .HasMaxLength(50);
            builder.Property(u => u.LastName)
                .HasMaxLength(50);
            builder.Property(u => u.Email)
                .HasMaxLength (50);
            builder.Property(u=>u.UserName)
                .HasMaxLength (50);
            builder.HasIndex(u => u.UserName)
                .IsUnique();
            builder.Property(u => u.PasswordHash)
                .HasMaxLength(64);
            builder.Property(u=>u.SecurityStamp)
                .HasMaxLength(64);
        }
    }
}
