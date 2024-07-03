using ContactUs.Business1.Admin.AllTours.TourDetail.Abstract;
using ContactUs.Business1.Admin.AllTours.TourDetail.Concrete;
using ContactUs.DataAccess1.Admin.AllTours.TourDetail;
using ContactUs.DataAccess1.Admin.AllTours.TourDetail.Concrete;
using ContactUs.Entities1.Admin.AllTours;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourDetailsController : ControllerBase
    {
        private ITourDetailsService _tourDetailsService;
        public TourDetailsController()
        {
            _tourDetailsService = new TourDetailsManager(new TourDetailsRepository(new TourDetailsDbContext()));
        }
        [HttpGet("all/{langid}")]
        public List<TourDetails> GetAllTourDetails(int langId)
        {
            return _tourDetailsService.GetAllTourDetails(langId).Result;
        }
        [HttpGet("details/{tourid}")]
        public TourDetails GetTourDetailsById(int tourId)
        {
            return _tourDetailsService.GetTourDetailsById(tourId).Result;
        }
        [HttpGet("all/{tourid}/{langid}")]
        public List<TourDetails> GetTourDetailsPage(int tourId , int langId)
        {
            return _tourDetailsService.GetTourDetailsPage(tourId,langId).Result;
        }
        [HttpGet("popular/{ısPopular}/{langid}")]
        public List<TourDetails> GetTourDetailsPopular(bool ısPopular, int langId)
        {
            return _tourDetailsService.GetTourDetailsPopular(ısPopular, langId).Result;
        }
        [HttpPost]
        public TourDetails Post([FromBody] TourDetails tourDetails)
        {
            return _tourDetailsService.AddTourDetails(tourDetails).Result;
        }
        [HttpPut]
        public TourDetails Put([FromBody] TourDetails tourDetails)
        {
            return _tourDetailsService.UpdateTourDetails(tourDetails).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _tourDetailsService.DeleteTourDetails(id);
        }
    }
}
