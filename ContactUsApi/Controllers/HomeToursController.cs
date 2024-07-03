using ContactUs.Business1.Admin.HomeTours.Abstract;
using ContactUs.Business1.Admin.HomeTours.Concrete;
using ContactUs.DataAccess1.Admin.HomeTours;
using ContactUs.DataAccess1.Admin.HomeTours.Concrete;
using ContactUs.Entities1.Admin.HomeTours;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeToursController : ControllerBase
    {
        private IHomeToursService _homeToursService;
        public HomeToursController()
        {
            _homeToursService = new HomeToursManager(new HomeToursRepository(new HomeToursDbContext()));
        }
        [HttpGet("all/{langid}")]
        public List<HomeTours> GetAllHomeTour(int langId)
        {
            return _homeToursService.GetAllHomeTours(langId).Result;
        }
        [HttpGet("{id}")]
        public HomeTours Get(int id)
        {
            return _homeToursService.GetHomeToursById(id).Result;
        }
        [HttpPost]
        public HomeTours Post([FromBody] HomeTours tours)
        {
            return _homeToursService.AddHomeTours(tours).Result;
        }
        [HttpPut]
        public HomeTours Put([FromBody] HomeTours tours)
        {
            return _homeToursService.UpdateHomeTours(tours).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _homeToursService.DeleteHomeTours(id);
        }
    }
    }
