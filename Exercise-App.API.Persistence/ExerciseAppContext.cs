using System;
using System.Collections.Generic;
using System.Text;
using Exercise_App.API.Application.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exercise_App.API.Persistence
{
    public class ExerciseAppContext : DbContext
    {
        public ExerciseAppContext(DbContextOptions<ExerciseAppContext> options) : base(options)
        {
        }

        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workout>().ToTable("Workout");
            modelBuilder.Entity<Exercise>().ToTable("Exercise");
        }
    }
}
