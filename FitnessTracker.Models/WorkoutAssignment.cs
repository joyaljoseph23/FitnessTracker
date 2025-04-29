using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
    public class WorkoutAssignment
    {
        [Key]
        public Guid Id { get; set; }
        public string InstructorName { get; set; }
        public string ExerciseName { get; set; }
        public int TargetReps { get; set; }
        public int RestTime { get; set; }
        public DateTime Date { get; set; }
        public int DayNumber { get; set; } // 1 to 7
        public Guid  CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }


    }
}
