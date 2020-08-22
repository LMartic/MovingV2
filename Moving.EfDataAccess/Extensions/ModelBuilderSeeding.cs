using Microsoft.EntityFrameworkCore;
using Moving.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.EfDataAccess.Extensions
{
    public static class ModelBuilderSeeding
    {
        public static void Seeding(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobStatuses>().HasData(
                new JobStatuses { Id = 1, JobStatus = "In Progress" },
                new JobStatuses { Id = 2, JobStatus = "Completed" }
                );
            modelBuilder.Entity<JobTypes>().HasData(
               new JobTypes { Id = 1, JobType = "1 bedrooms" },
               new JobTypes { Id = 2, JobType = "2 bedrooms" },
               new JobTypes { Id = 3, JobType = "3 bedrooms" },
               new JobTypes { Id = 4, JobType = "more than 3 bedrooms" }
               );
            modelBuilder.Entity<Roles>().HasData(
             new Roles { Id = 1, RoleName = "Manager", CreatedAt = DateTime.Now },
             new Roles { Id = 2, RoleName = "Sales Agent", CreatedAt = DateTime.Now },
             new Roles { Id = 3, RoleName = "Contractor", CreatedAt = DateTime.Now }
             );
            modelBuilder.Entity<Permissions>().HasData(
               new Permissions { Id = 1, Name = "Create New Customer", Description = "Create New Customer", CreatedAt = DateTime.Now },
               new Permissions { Id = 2, Name = "Delete Customer", Description = "Delete Customer", CreatedAt = DateTime.Now },
               new Permissions { Id = 3, Name = "Update Customer", Description = "Update Customer", CreatedAt = DateTime.Now },
               new Permissions { Id = 4, Name = "Customer search", Description = "Customer search", CreatedAt = DateTime.Now },
               new Permissions { Id = 5, Name = "Create New Job", Description = "Create New Job", CreatedAt = DateTime.Now },
               new Permissions { Id = 6, Name = "Update Job", Description = "Update Job", CreatedAt = DateTime.Now },
               new Permissions { Id = 7, Name = "Job search", Description = "Job search", CreatedAt = DateTime.Now },
               new Permissions { Id = 8, Name = "Delete Job", Description = "Delete Job", CreatedAt = DateTime.Now },
               new Permissions { Id = 9, Name = "Use Case Search", Description = "Use Case Search", CreatedAt = DateTime.Now },
               new Permissions { Id = 10, Name = "Role Search", Description = "Role Search", CreatedAt = DateTime.Now },
               new Permissions { Id = 11, Name = "Create new Role", Description = "Create new Role", CreatedAt = DateTime.Now },
               new Permissions { Id = 12, Name = "Update Role", Description = "Update Role", CreatedAt = DateTime.Now },
               new Permissions { Id = 13, Name = "Create New Job Review", Description = "Create New Job Review", CreatedAt = DateTime.Now },
               new Permissions { Id = 14, Name = "Delete Job Review", Description = "Delete Job Review", CreatedAt = DateTime.Now },
               new Permissions { Id = 15, Name = "JobReview Search", Description = "JobReview Search", CreatedAt = DateTime.Now }
               );
            modelBuilder.Entity<RolePermissions>().HasData(
              new RolePermissions { RoleId = 1, PermissionId = 1 },
              new RolePermissions { RoleId = 2, PermissionId = 1 },
              new RolePermissions { RoleId = 1, PermissionId = 2 },
              new RolePermissions { RoleId = 1, PermissionId = 3 },
              new RolePermissions { RoleId = 2, PermissionId = 3 },
              new RolePermissions { RoleId = 1, PermissionId = 4 },
              new RolePermissions { RoleId = 2, PermissionId = 4 },
              new RolePermissions { RoleId = 1, PermissionId = 5 },
              new RolePermissions { RoleId = 2, PermissionId = 5 },
              new RolePermissions { RoleId = 1, PermissionId = 6 },
              new RolePermissions { RoleId = 2, PermissionId = 6 },
              new RolePermissions { RoleId = 1, PermissionId = 7 },
              new RolePermissions { RoleId = 2, PermissionId = 7 },
              new RolePermissions { RoleId = 1, PermissionId = 8 },
              new RolePermissions { RoleId = 1, PermissionId = 9 },
              new RolePermissions { RoleId = 2, PermissionId = 9 },
              new RolePermissions { RoleId = 1, PermissionId = 10 },
              new RolePermissions { RoleId = 1, PermissionId = 11 },
              new RolePermissions { RoleId = 1, PermissionId = 12 },
              new RolePermissions { RoleId = 1, PermissionId = 15 },
              new RolePermissions { RoleId = 3, PermissionId = 13 },
              new RolePermissions { RoleId = 3, PermissionId = 14 },
              new RolePermissions { RoleId = 3, PermissionId = 15 }

              );
            modelBuilder.Entity<Customers>().HasData(
                new Customers { Id = 1, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Mike", LastName = "Young", Phone = "38166415304", Email = "mikey@gmail.com"},
                new Customers { Id = 2, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Lazar", LastName = "Martic", Phone = "321321321", Email = "low@gmail.com" },
                new Customers { Id = 3, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "John", LastName = "J", Phone = "3838388585", Email = "john@gmail.com" },
                new Customers { Id = 4, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Adam", LastName = "Boston", Phone = "9859859585", Email = "adam@gmail.com" },
                new Customers { Id = 5, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Jack", LastName = "Smit", Phone = "0128377344", Email = "jack@gmail.com" },
                new Customers { Id = 6, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Josh", LastName = "Douce", Phone = "9128709845", Email = "josh@gmail.com" },
                new Customers { Id = 7, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Jenny", LastName = "Summer", Phone = "9558290385", Email = "jenny@gmail.com" },
                new Customers { Id = 8, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Anna", LastName = "Sinatra", Phone = "7520935743", Email = "ana@gmail.com" },
                new Customers { Id = 9, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Suzanne", LastName = "Old", Phone = "398529358", Email = "suzanne@gmail.com" },
                new Customers { Id = 10, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Amy", LastName = "Fin", Phone = "75209355743", Email = "amy@gmail.com" },
                new Customers { Id = 11, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Bruce", LastName = "Jordan", Phone = "752096535743", Email = "bruce@gmail.com" },
                new Customers { Id = 12, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Ron", LastName = "Boring", Phone = "8166415304", Email = "ron@gmail.com" },
                new Customers { Id = 13, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Jimmy", LastName = "Falon", Phone = "41284195", Email = "jimmy@gmail.com" }

                );
            modelBuilder.Entity<Users>().HasData(
                new Users { Id = 1, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Admin", LastName = "Admin", Email = "admin@gmail.com", UserName = "admin", Password ="sifra123",  },
                new Users { Id = 2, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Sales", LastName = "Manager", Email = "sales@gmail.com", UserName = "sale", Password = "sifra123" },
                new Users { Id = 3, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Contractor", LastName = "Contractor", Email = "contractor@gmail.com", UserName = "contractor", Password = "sifra123" },
                new Users { Id = 4, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Jhonny", LastName = "Cash", Email = "honny@gmail.com", UserName = "honny", Password = "sifra123" },
                new Users { Id = 5, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Mike", LastName = "Dean", Email = "mike@gmail.com", UserName = "mike", Password = "sifra123" },
                new Users { Id = 6, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Frank", LastName = "Sinatra", Email = "frank@gmail.com", UserName = "frank", Password = "sifra123" },
                new Users { Id = 7, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Josh", LastName = "Francis", Email = "josh@gmail.com", UserName = "josh", Password = "sifra123" },
                new Users { Id = 8, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Anna", LastName = "Shmit", Email = "anna@gmail.com", UserName = "anna", Password = "sifra123" },
                new Users { Id = 9, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Boris", LastName = "Malagurski", Email = "boris@gmail.com", UserName = "boris", Password = "sifra123" },
                new Users { Id = 10, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Pike", LastName = "Hook", Email = "pike@gmail.com", UserName = "pike", Password = "sifra123" },
                new Users { Id = 11, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Donald", LastName = "Trump", Email = "donald@gmail.com", UserName = "donald", Password = "sifra123" },
                new Users { Id = 12, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Mike", LastName = "Luis", Email = "mike@gmail.com", UserName = "mike", Password = "sifra123" },
                new Users { Id = 13, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Dzim", LastName = "Sharp", Email = "dzim@gmail.com", UserName = "dzim", Password = "sifra123" },
                new Users { Id = 14, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Fanta", LastName = "Stick", Email = "fanta@gmail.com", UserName = "fanta", Password = "sifra123" },
                new Users { Id = 15, CreatedAt = DateTime.Now, IsDeleted = false, FirstName = "Sam", LastName = "Fisher", Email = "sam@gmail.com", UserName = "sam", Password = "sifra123" }

                );
     
        }
    }
}