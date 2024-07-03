using ContactUs.Entities1.Admin.AllTours;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.AllTours.Category.Abstract
{
    public  interface ICategoriesRepository
    {
        Task<List<Categories>> GetAllCategories();
        Task<Categories> GetCategoriesById(int id);
    }
}
