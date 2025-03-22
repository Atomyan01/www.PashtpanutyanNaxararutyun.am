using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using www.PashtpanutyanNaxararutyun.am.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity;
using www.PashtpanutyanNaxararutyun.am.Models;

namespace www.PashtpanutyanNaxararutyun.am
{
    public class DContext : IdentityDbContext<UserModel>
    {
        public www.PashtpanutyanNaxararutyun.am(DbContextOptions<www.PashtpanutyanNaxararutyun.am> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().Ignore(c => c.AccessFailedCount)
                                           .Ignore(c => c.LockoutEnabled)
                                           .Ignore(c => c.ConcurrencyStamp)
                                           .Ignore(c => c.TwoFactorEnabled)
                                           .Ignore(c => c.EmailConfirmed)
                                           .Ignore(c => c.SecurityStamp)
                                           .Ignore(c => c.PhoneNumberConfirmed)
                                           .Ignore(c => c.LockoutEnd)
                                           .Ignore(c => c.NormalizedEmail)
                                           .Ignore(c => c.NormalizedUserName)
                                           .Ignore(c => c.UserName)
                                           .Ignore(c => c.Email)
                                           .Ignore(c => c.PasswordHash);
            

            modelBuilder.Entity<UserModel>().ToTable("AspNetUsers");
            modelBuilder.Entity<AuthorModel>().ToTable("Authors");


            modelBuilder.Entity<AwardModel>()
                .HasOne(a => a.Creator)
                .WithMany(u => u.CreatedAwards)
                .HasForeignKey("CreatorId")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VoteAwardModel>()
                .HasOne(v => v.Creator)
                .WithMany(u => u.CreatedPolls)
                .HasForeignKey("CreatorId")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VoteAwardModel>()
                .HasMany(v => v.VotedUsers)
                .WithMany(u => u.VotedPolls)
                .UsingEntity<Dictionary<string, object>>(
                    "UserVoteAwards",
                    j => j.HasOne<UserModel>().WithMany().HasForeignKey("UserId"),
                    j => j.HasOne<VoteAwardModel>().WithMany().HasForeignKey("VoteAwardId"),
                    j => j.HasKey("UserId", "VoteAwardId")
                );

            modelBuilder.Entity<AwardModel>()
                .HasMany(a => a.Funders)
                .WithMany(u => u.FundedAwards)
                .UsingEntity<Dictionary<string, object>>(
                    "UserFundedAwards",
                    j => j.HasOne<UserModel>().WithMany().HasForeignKey("UserId"),
                    j => j.HasOne<AwardModel>().WithMany().HasForeignKey("AwardId"),
                    j => j.HasKey("UserId", "AwardId")
                );

            modelBuilder.Entity<VoteAwardModel>()
                .HasMany(v => v.Funders)
                .WithMany(u => u.FundedPolls)
                .UsingEntity<Dictionary<string, object>>(
                    "UserFundedVoteAwards",
                    j => j.HasOne<UserModel>().WithMany().HasForeignKey("UserId"),
                    j => j.HasOne<VoteAwardModel>().WithMany().HasForeignKey("VoteAwardId"),
                    j => j.HasKey("UserId", "VoteAwardId")
                );
        }

        public DbSet<BookModel> BookModel { get; set; } = default!;
        public DbSet<AuthorModel> AuthorModel { get; set; } = default!;
        public DbSet<UserModel> UserModel { get; set; } = default!;
        public DbSet<OrderModel> Orders { get; set; } = default!;
        public DbSet<ReviewModel> ReviewModel { get; set; } = default!;
        public DbSet<VoteAwardModel> VoteAwardModel { get; set; }
        public DbSet<VoteOptionModel> VoteOptionModel { get; set; }

    }
}
