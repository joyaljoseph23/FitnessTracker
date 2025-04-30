using FitnessTracker.DataAccess.Repository.IRepository;
using FitnessTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {

        private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Category obj)
        {
            _context.categories.Update(obj);
        }
    }
}
