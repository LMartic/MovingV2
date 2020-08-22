using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Moving.Domain;

namespace Moving.EfDataAccess.Configurations
{
    public class JobStatusConfiguration : IEntityTypeConfiguration<JobStatuses>
    {
        public void Configure(EntityTypeBuilder<JobStatuses> entity)
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.JobStatus)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);
        }
    }
}
