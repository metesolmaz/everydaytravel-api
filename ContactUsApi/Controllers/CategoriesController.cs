using ContactUs.Business1.Admin.AboutUs.Abstract;
using ContactUs.Business1.Admin.AboutUs.Concrete;
using ContactUs.Business1.Admin.AllTours.Category.Abstract;
using ContactUs.DataAccess1.Admin.AboutUs.Concrete;
using ContactUs.DataAccess1.Admin.AboutUs;
using ContactUs.Entities1.Admin.AllTours;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ContactUs.Business1.Admin.AllTours.Category.Concrete;
using ContactUs.DataAccess1.Admin.AllTours.Category.Concrete;
using ContactUs.DataAccess1.Admin.AllTours.Category;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public CategoriesController()
        {
            _categoriesService = new CategoriesManager(new CategoriesRepository(new CategoriesDbContext()));
        }
        [HttpGet]
        public  List<Categories> Get()
        {
            return _categoriesService.GetAllCategories().Result;
        }

        [HttpGet("{id}")]
        public  Categories GetCategoriesById(int id)
        {
            return  _categoriesService.GetCategoriesById(id).Result;
        }
    }
}
