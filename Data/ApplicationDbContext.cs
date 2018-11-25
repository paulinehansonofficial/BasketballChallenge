using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using final_challenge.Models;

namespace final_challenge.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {    }

        public DbSet<Member> Members { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MemberGame>()
                .HasOne(md => md.Member)
                .WithMany(md => md.GamesPlayed)
                .HasForeignKey(md => md.Id);
            
            modelBuilder.Entity<MemberGame>()
                .HasOne(md => md.Game)
                .WithMany(md => md.Players)
                .HasForeignKey(md => md.GameId);

            modelBuilder.Entity<Member>()
                .Property(b => b.TotalSpend)
                .HasDefaultValue(0.00);
            
            modelBuilder.Entity<Member>()
                .Property(b => b.Status)
                .HasDefaultValue(MemberStatus.Pending);

        }
    }
}
