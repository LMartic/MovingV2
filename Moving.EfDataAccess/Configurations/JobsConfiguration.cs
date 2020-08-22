using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Moving.Domain;

namespace Moving.EfDataAccess.Configurations
{
    public class JobsConfiguration : IEntityTypeConfiguration<Jobs>
    {
        public void Configure(EntityTypeBuilder<Jobs> entity)
        {
            entity.Property(e => e.Deposit).HasColumnType("decimal(10, 2)");

            entity.Property(e => e.MoveDate).HasColumnType("datetime");

            entity.Property(e => e.PricePerHour).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.CreatedByUser)
                .WithMany(p => p.Jobs)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Jobs_Users");

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.Jobs)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Jobs_Customers");

            entity.HasOne(d => d.JobStatus)
                .WithMany(p => p.Jobs)
                .HasForeignKey(d => d.JobStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Jobs_JobStatuses");

            entity.HasOne(d => d.JobType)
                .WithMany(p => p.Jobs)
                .HasForeignKey(d => d.JobTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Jobs_JobTypes");
        }
    }
}
