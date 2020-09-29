using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeaderboardAPI.Models;
//using System.Data.Entity;



namespace LeaderboardAPI.Database
{
    public class LeaderAPIDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Level> Levels { get; set; }

        public LeaderAPIDbContext(DbContextOptions<LeaderAPIDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().ToTable("Players").HasData(
                new Player { Id = 1, Name = "Player1", CountryCode = 1 });
            modelBuilder.Entity<Score>().ToTable("Scores").HasData(
                new Score { PlayerId = 1, ScoreId = 1, TimeinSeconds = 20, HighScore = 20, LevelId = 11 });
            modelBuilder.Entity<Level>().ToTable("Levels").HasData(
                new Level { Id = 111, LevelName = "FirstLevel" });
        }
    }
}
