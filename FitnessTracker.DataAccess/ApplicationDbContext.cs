using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Workout> workouts { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<WorkoutAssignment> workoutAssignments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Category>().HasData((
            //    new Category
            //    {
            //        Id=Guid.NewGuid(),
            //        AimedBodyPart="Leg"
            //    },new Category
            //    {
            //        Id = Guid.NewGuid(),
            //        AimedBodyPart = "Chest"
            //    },
            //    new Category

            //    {
            //        Id = Guid.NewGuid(),
            //        AimedBodyPart = "Shoulder"
            //    },
            //    new Category
            //    {
            //        Id = Guid.NewGuid(),
            //        AimedBodyPart = "Biceps and Triceps"
            //    },
            //    new Category
            //    {
            //        Id = Guid.NewGuid(),
            //        AimedBodyPart = "Abs"
            //    }
            //));

            //modelBuilder.Entity<Workout>().HasData(
                
            //    new Workout
            //    {
            //        Id = ,
            //        WorkoutName = "Morning Push-ups",
            //        CompletedReps = 22,
            //        WeightKg = 0,
            //        Duration = 5,
            //        Date = DateTime.Parse("2025-04-01"),
            //        AssignmentId = 1
            //    },

            //);
        }

    }
}
