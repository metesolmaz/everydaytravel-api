using ContactUs.Business1.Admin.Menu.Abstract;
using ContactUs.Business1.Admin.Menu.Concrete;
using ContactUs.DataAccess1.Admin.Services;
using ContactUs.DataAccess1.Admin.Services.Concrete;
using ContactUs.Entities1.Admin.Menu;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private IMenuService _menuService;
        public MenuController()
        {
            _menuService = new MenuManager(new MenuRepository(new MenuDbContext()));
        }
        [HttpGet("all/{langid}")]
        public List<HorizontalNavbar> GetAllMenu(int langId)
        {
            return _menuService.GetAllMenu(langId).Result;
        }
        [HttpGet("{id}")]
        public HorizontalNavbar Get(int id)
        {
            return _menuService.GetMenuById(id).Result;
        }
        [HttpPost]
        public HorizontalNavbar Post([FromBody] HorizontalNavbar menu)
        {
            return _menuService.AddMenu(menu).Result;
        }
        [HttpPut]
        public HorizontalNavbar Put([FromBody] HorizontalNavbar menu)
        {
            return _menuService.UpdateMenu(menu).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _menuService.DeleteMenu(id);
        }
    }
}
