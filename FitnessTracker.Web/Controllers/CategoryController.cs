using FitnessTracker.DataAccess.Repository.IRepository;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Web.Controllers
{

    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryController(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Category> lstCategory = _categoryRepo.GetAll().ToList();
            return View(lstCategory);
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(ModelState.IsValid)
            {
                _categoryRepo.Add(obj);
                _categoryRepo.Save();
                return RedirectToAction("Index"); 
            }
            return View();
        }
    }
}
