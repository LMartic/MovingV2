using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Moving.Domain;
using Moving.EfDataAccess.Configurations;
using Moving.EfDataAccess.Extensions;

namespace Moving.EfDataAccess
{
    public partial class MovingContext : DbContext
    {
        public MovingContext()
        {
        }

        public MovingContext(DbContextOptions<MovingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<JobStatuses> JobStatuses { get; set; }
        public virtual DbSet<JobTypes> JobTypes { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<RolePermissions> RolePermissions { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UseCaseLog> UseCaseLogs { get; set; }
        public virtual DbSet<JobImages> JobImages { get; set; }
        public virtual DbSet<JobReviews> JobReviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=MovingDb;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomersConfiguration());
            modelBuilder.ApplyConfiguration(new JobsConfiguration());
            modelBuilder.ApplyConfiguration(new JobStatusConfiguration());
            modelBuilder.ApplyConfiguration(new JobTypesConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RolePermissionConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new JobReviewsConfiguration());
            

            modelBuilder.Entity<Customers>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Jobs>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Roles>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Users>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Permissions>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<JobReviews>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Seeding();
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is Entity e)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            e.IsActive = true;
                            e.IsDeleted = false;
                            e.CreatedAt = DateTime.Now;
                            e.DeletedAt = null;
                            e.ModifiedAt = null;
                            break;
                        case EntityState.Modified:
                            e.ModifiedAt = DateTime.Now;
                            break;
                    }
                }
            }
            return base.SaveChanges();
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
