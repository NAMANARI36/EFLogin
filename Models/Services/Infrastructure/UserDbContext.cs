using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EFLogin.Models.Entities;

namespace EFLogin.Models.Entities
{
    public partial class UserDbContext : DbContext
    {

        public UserDbContext() { }

        public UserDbContext(DbContextOptions<UserDbContext> options)
                    : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=Data/Utenti.db");
            }
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
            //Mappatura con le Fluent API
            modelBuilder.Entity<User>()
            .ToTable("Users");

            modelBuilder.Entity<User>()
            .Property(u => u.Id)
            .HasColumName("ID");

            modelBuilder.Entity<User>()
            .Property(u => u.Password)
            .HasColumName("Password");

            modelBuilder.Entity<User>()
            .Property(u => u.Name)
            .HasColumnName("Name");

            modelBuilder.Entity<User>()
            .Property(u => u.Country)
            .HasColumnName("Country");

            modelBuilder.Entity<User>()
            .Property(u => u.Email)
            .HasColumnName("Email");
        }
        




    }
}
