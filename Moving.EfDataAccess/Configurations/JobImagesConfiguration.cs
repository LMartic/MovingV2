using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Moving.Domain;

namespace Moving.EfDataAccess.Configurations
{
    public class JobImagesConfiguration : IEntityTypeConfiguration<JobImages>
    {
        public void Configure(EntityTypeBuilder<JobImages> entity)
        {
            entity.Property(e => e.ImagePath).HasColumnType("nvarchar(MAX)");
            entity.HasOne(d => d.Job)
                            .WithMany(p => p.JobImages)
                            .HasForeignKey(d => d.JobId)
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_JobImages_Job");
        }
    }
}
