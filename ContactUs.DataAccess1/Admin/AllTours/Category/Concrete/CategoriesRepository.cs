using ContactUs.DataAccess1.Admin.AllTours.Category.Abstract;
using ContactUs.DataAccess1.Migrations.MainToursDb;
using ContactUs.Entities1.Admin.AllTours;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.AllTours.Category.Concrete
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly CategoriesDbContext _categories;
        public CategoriesRepository(CategoriesDbContext categories)
        {
            _categories = categories;
        }

        public async Task<List<Categories>> GetAllCategories()
        {
            return await _categories.Categories.ToListAsync();
        }

        public async Task<Categories> GetCategoriesById(int id)
        {
            return await _categories.Categories.FindAsync(id);
        }
    }
}
