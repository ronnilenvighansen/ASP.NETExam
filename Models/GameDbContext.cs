using System;
using Microsoft.EntityFrameworkCore;
using ThisIsMyExam.Models.Entities;

namespace ThisIsMyExam.Models
{
    public class GameDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("GameConnection");
        }

    }

}