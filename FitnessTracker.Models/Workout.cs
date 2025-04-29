namespace FitnessTracker.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public DateTime Date { get; set; }
    }
}
