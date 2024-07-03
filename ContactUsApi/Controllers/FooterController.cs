using ContactUs.Business1.Admin.Footers.Abstract;
using ContactUs.Business1.Admin.Footers.Concrete;
using ContactUs.DataAccess1.Admin.Footers;
using ContactUs.DataAccess1.Admin.Footers.Concrete;
using ContactUs.Entities1.Admin.Footers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterController : ControllerBase
    {
        private IFooterService _footerService;
        public FooterController()
        {
            _footerService = new FooterManager(new FooterRepository(new FooterDbContext()));
        }
        [HttpGet("all/{langid}")]
        public List<Footer> GetAllFooter(int langId)
        {
            return _footerService.GetAllFooters(langId).Result;
        }
        [HttpGet("{id}")]
        public Footer Get(int id)
        {
            return _footerService.GetFooterById(id).Result;
        }
        [HttpPost]
        public Footer Post([FromBody] Footer footer)
        {
            return _footerService.AddFooter(footer).Result;
        }
        [HttpPut]
        public Footer Put([FromBody] Footer footer)
        {
            return _footerService.UpdateFooter(footer).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _footerService.DeleteFooter(id);
        }
    }
}
