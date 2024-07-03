using ContactUs.Business1.Admin.AboutUs.Abstract;
using ContactUs.Business1.Admin.AboutUs.Concrete;
using ContactUs.DataAccess1.Admin.AboutUs;
using ContactUs.DataAccess1.Admin.AboutUs.Concrete;
using ContactUs.Entities1.Admin.AboutUs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private IAboutUsService _aboutUsService;
        public AboutUsController()
        {
            _aboutUsService = new AboutUsManager(new AboutUsRepository(new AboutUsDbContext()));
        }
        [HttpGet("all/{langid}")]
        public List<About> GetAllAboutUs(int langId)
        {
            return _aboutUsService.GetAllAbouts(langId).Result;
        }
        [HttpGet("{id}")]
        public About Get(int id)
        {
            return _aboutUsService.GetAboutById(id).Result;
        }
        [HttpPost]
        public About Post([FromBody] About about)
        {
            return _aboutUsService.AddAbout(about).Result;
        }
        [HttpPut]
        public About Put([FromBody] About about)
        {
            return _aboutUsService.UpdateAbout(about).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _aboutUsService.DeleteAbout(id);
        }
    }
}
