using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Models
{
    public class Workout
    {
        [Key]
        public Guid Id { get; set; }
        public string WorkoutName { get; set; }
        public int CompletedReps { get; set; }
        public int WeightKg { get; set; }
        public int Duration { get; set; }
        public DateTime Date { get; set; }
        public Guid AssignmentId { get; set; }
        [ForeignKey("AssignmentId")]
        public WorkoutAssignment Assignment { get; set; }
    }
}
