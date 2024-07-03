using ContactUs.Business1.Admin.AllTours.MainTour.Abstract;
using ContactUs.Business1.Admin.AllTours.MainTour.Concrete;
using ContactUs.DataAccess1.Admin.AllTours.MainTour;
using ContactUs.DataAccess1.Admin.AllTours.MainTour.Concrete;
using ContactUs.Entities1.Admin.AllTours;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainToursController : ControllerBase
    {
        private IMainTourService _mainTourService;
        public MainToursController()
        {
            _mainTourService = new MainTourManager(new MainToursRepository(new MainToursDbContext()));
        }
        [HttpGet("all/{langid}")]
        public List<MainTours> GetAllMainTours(int langId)
        {
            return _mainTourService.GetAllMainTours(langId).Result;
        }
        [HttpGet("{id}")]
        public MainTours GetMainToursById(int id)
        {
            return _mainTourService.GetMainToursById(id).Result;
        }
        [HttpPost]
        public MainTours Post([FromBody] MainTours mainTours)
        {
            return _mainTourService.AddMainTours(mainTours).Result;
        }
        [HttpPut]
        public MainTours Put([FromBody] MainTours mainTours)
        {
            return _mainTourService.UpdateMainTours(mainTours).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mainTourService.DeleteMainTours(id);
        }
    }
}
