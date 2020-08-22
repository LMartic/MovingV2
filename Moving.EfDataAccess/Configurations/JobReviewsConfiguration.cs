using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Moving.Domain;

namespace Moving.EfDataAccess.Configurations
{
    public class JobReviewsConfiguration : IEntityTypeConfiguration<JobReviews>
    {
        public void Configure(EntityTypeBuilder<JobReviews> entity)
        {
            entity.Property(e => e.Description).HasColumnType("nvarchar(MAX)");
            entity.HasOne(d => d.Job)
                            .WithMany(p => p.JobReviews)
                            .HasForeignKey(d => d.JobId)
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_JobReviews_Job");
            entity.HasOne(d => d.User)
                           .WithMany(p => p.JobReviews)
                           .HasForeignKey(d => d.UserId)
                           .OnDelete(DeleteBehavior.ClientSetNull)
                           .HasConstraintName("FK_JobReviews_User");
        }
    }
}
