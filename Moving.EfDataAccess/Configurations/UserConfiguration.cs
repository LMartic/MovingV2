using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Moving.Domain;

namespace Moving.EfDataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> entity)
        {
            entity.Property(e => e.Email)
                     .IsRequired()
                     .HasMaxLength(150)
                     .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.Password).IsRequired();

            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);
        }
    }
}
