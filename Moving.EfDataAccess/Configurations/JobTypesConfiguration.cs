using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Moving.Domain;

namespace Moving.EfDataAccess.Configurations
{
    public class JobTypesConfiguration : IEntityTypeConfiguration<JobTypes>
    {
        public void Configure(EntityTypeBuilder<JobTypes> entity)
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.JobType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
