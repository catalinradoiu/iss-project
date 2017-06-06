﻿using App.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Context
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public DbSet<Section> Sections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>()
                .HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<UserRole>()
                .HasOne(x => x.User)
                .WithMany(x => x.UserRoles)
                .HasForeignKey(x => x.UserId);
            modelBuilder.Entity<UserRole>()
                .HasOne(x => x.Role)
                .WithMany(x => x.UserRoles)
                .HasForeignKey(x => x.RoleId);

            modelBuilder.Entity<UserSection>()
                .HasKey(x => new { x.UserId, x.SectionId });
            modelBuilder.Entity<UserSection>()
                .HasOne(x => x.User)
                .WithMany(x => x.UserSections)
                .HasForeignKey(x => x.UserId);
            modelBuilder.Entity<UserSection>()
                .HasOne(x => x.Section)
                .WithMany(x => x.UserSections)
                .HasForeignKey(x => x.SectionId);

            modelBuilder.Entity<ConferenceUser>()
                .HasKey(x => new { x.ConferenceId, x.UserId });
            modelBuilder.Entity<ConferenceUser>()
                .HasOne(x => x.Conference)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.ConferenceId);
            modelBuilder.Entity<ConferenceUser>()
                .HasOne(x => x.User)
                .WithMany(x => x.ConferenceUsers)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Topic>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Section>()
                .HasIndex(s => s.Name)
                .IsUnique();

            modelBuilder.Entity<Section>()
                .HasIndex(s => s.Room)
                .IsUnique();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=DESKTOP-C6EA23V\SQLEXPRESS;Initial Catalog=iss;Integrated Security=True");
        }
    }
}
