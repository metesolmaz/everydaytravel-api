using ContactUs.Business1.Admin.ToursViews.Abstract;
using ContactUs.Business1.Admin.ToursViews.Concrete;
using ContactUs.DataAccess1.Admin.ToursViews;
using ContactUs.DataAccess1.Admin.ToursViews.Concrete;
using ContactUs.Entities1.Admin.ToursViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToursViewController : ControllerBase
    {
        private IToursViewService _toursViewService;
        public ToursViewController()
        {
            _toursViewService = new ToursViewManager(new ToursViewRepository(new ToursViewDbContext()));
        }
        [HttpGet("all/{langid}")]
        public List<ToursView> GetAllToursView(int langId)
        {
            return _toursViewService.GetAllToursView(langId).Result;
        }
        [HttpGet("{id}")]
        public ToursView GetToursViewById(int id)
        {
            return _toursViewService.GetToursViewById(id).Result;
        }
        [HttpPost]
        public ToursView Post([FromBody] ToursView toursView)
        {
            return _toursViewService.AddToursView(toursView).Result;
        }
        [HttpPut]
        public ToursView Put([FromBody] ToursView toursView)
        {
            return _toursViewService.UpdateToursView(toursView).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _toursViewService.DeleteToursView(id);
        }
    }
}
