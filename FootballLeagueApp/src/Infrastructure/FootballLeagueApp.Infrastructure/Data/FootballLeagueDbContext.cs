using FootballLeagueApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Infrastructure.Data
{
    public class FootballLeagueDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Standing> Standings { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RulesForTeamProperties(modelBuilder);

            RulesForPlayerProperties(modelBuilder);

            RulesForStatisticProperties(modelBuilder);

            RulesForCoachProperties(modelBuilder);

            RulesForMatchProperties(modelBuilder);

            RulesForStandingProperties(modelBuilder);

            RulesForStadiumProperties(modelBuilder);

            modelBuilder.Entity<Team>().HasOne(t => t.Coach)
                                       .WithOne(c => c.Team)
                                       .HasForeignKey<Team>(t => t.CoachId)
                                       .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>().HasOne(t => t.Stadium)
                                       .WithOne(s => s.Team)
                                       .HasForeignKey<Team>(t => t.StadiumId)
                                       .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Player>().HasOne(p => p.Team)
                                         .WithMany(t => t.Players)
                                         .HasForeignKey(p => p.TeamId)
                                         .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Match>().HasOne(m => m.HomeTeam)
                                        .WithMany(t => t.HomeMatches)
                                        .HasForeignKey(m => m.HomeTeamId)
                                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Match>().HasOne(m => m.AwayTeam)
                                        .WithMany(t => t.AwayMatches)
                                        .HasForeignKey(m => m.AwayTeamId)
                                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Team>().HasOne(t => t.Coach)
                                       .WithOne(c => c.Team)
                                       .HasForeignKey<Team>(t => t.CoachId)
                                       .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Player>().HasOne(p => p.Statistic)
                                         .WithOne(s => s.Player)
                                         .HasForeignKey<Player>(p => p.StatisticId)
                                         .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Match>().HasOne(m => m.Stadium)
                                        .WithMany(s => s.Matches)
                                        .HasForeignKey(m => m.StadiumId)
                                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Standing>().HasOne(s => s.Team)
                                           .WithOne()
                                           .HasForeignKey<Standing>(s => s.TeamId)
                                           .OnDelete(DeleteBehavior.NoAction);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=FootballLeague;Integrated Security=True");
        }

        private static void RulesForTeamProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().Property(t => t.Name)
                                       .IsRequired()
                                       .HasMaxLength(100);

            modelBuilder.Entity<Team>().Property(t => t.FoundingDate)
                                       .IsRequired();
        }

        private static void RulesForPlayerProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().Property(p => p.FirstName)
                                         .IsRequired()
                                         .HasMaxLength(100);

            modelBuilder.Entity<Player>().Property(p => p.LastName)
                                         .IsRequired()
                                         .HasMaxLength(100);

            modelBuilder.Entity<Player>().Property(p => p.Age)
                                         .IsRequired();

            modelBuilder.Entity<Player>().Property(p => p.Position)
                                         .IsRequired()
                                         .HasMaxLength(50);

            modelBuilder.Entity<Player>().Property(p => p.Nationality)
                                         .IsRequired()
                                         .HasMaxLength(100);
        }

        private static void RulesForStatisticProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Statistic>().Property(s => s.Match)
                                            .IsRequired();

            modelBuilder.Entity<Statistic>().Property(s => s.Goal)
                                            .IsRequired();

            modelBuilder.Entity<Statistic>().Property(s => s.Assist)
                                            .IsRequired();

            modelBuilder.Entity<Statistic>().Property(s => s.YellowCard)
                                            .IsRequired();

            modelBuilder.Entity<Statistic>().Property(s => s.RedCard)
                                            .IsRequired();
        }

        private static void RulesForCoachProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coach>().Property(c => c.FirstName)
                                        .IsRequired()
                                        .HasMaxLength(100);

            modelBuilder.Entity<Coach>().Property(c => c.LastName)
                                        .IsRequired()
                                        .HasMaxLength(100);

            modelBuilder.Entity<Coach>().Property(c => c.Age)
                                        .IsRequired();

            modelBuilder.Entity<Coach>().Property(c => c.Nationality)
                                        .IsRequired()
                                        .HasMaxLength(100);
        }

        private static void RulesForMatchProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>().Property(m => m.Date)
                                        .IsRequired();

            modelBuilder.Entity<Match>().Property(m => m.Result)
                                        .IsRequired()
                                        .HasMaxLength(10);
        }

        private static void RulesForStandingProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Standing>().Property(s => s.Score)
                                           .IsRequired();

            modelBuilder.Entity<Standing>().Property(s => s.Win)
                                           .IsRequired();

            modelBuilder.Entity<Standing>().Property(s => s.Draw)
                                           .IsRequired();

            modelBuilder.Entity<Standing>().Property(s => s.Defeat)
                                           .IsRequired();

            modelBuilder.Entity<Standing>().Property(s => s.GoalsFor)
                                           .IsRequired();

            modelBuilder.Entity<Standing>().Property(s => s.GoalsAgainst)
                                           .IsRequired();
        }

        private static void RulesForStadiumProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stadium>().Property(s => s.Name)
                                          .IsRequired()
                                          .HasMaxLength(100);

            modelBuilder.Entity<Stadium>().Property(s => s.Capacity)
                                          .IsRequired();

            modelBuilder.Entity<Stadium>().Property(s => s.Address)
                                          .IsRequired()
                                          .HasMaxLength(250);
        }
    }
}
