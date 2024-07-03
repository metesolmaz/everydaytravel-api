using ContactUs.Business1.Admin.AllTours.Category.Abstract;
using ContactUs.DataAccess1.Admin.AllTours.Category.Abstract;
using ContactUs.Entities1.Admin.AllTours;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.AllTours.Category.Concrete
{
    public  class CategoriesManager : ICategoriesService
    {
        private readonly ICategoriesRepository _categoriesRepository;
        public CategoriesManager(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }
        public  Task<List<Categories>> GetAllCategories()
        {
            return  _categoriesRepository.GetAllCategories();
        }
        public  Task<Categories> GetCategoriesById(int id)
        {
            return  _categoriesRepository.GetCategoriesById(id);
        }
        
    }
}
