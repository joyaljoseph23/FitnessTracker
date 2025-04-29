using FitnessTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Web.Controllers
{
    public class WorkoutController : Controller
    {
        private static List<Workout> workouts = new List<Workout>();
        public IActionResult Index()
        {
            return View(workouts);
        }
        public IActionResult Add()
        {
            return View(new Workout());
        }
        [HttpPost]
        public IActionResult Add(Workout workout)
        {
            if(ModelState.IsValid)
            {
                workouts.Add(workout);
                return RedirectToAction("Index");
            }
            return View(workout);
        }
    }
}
