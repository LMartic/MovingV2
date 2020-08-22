using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Moving.Domain;

namespace Moving.EfDataAccess.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> entity)
        {

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.RoleName)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);
        }
    }
}
