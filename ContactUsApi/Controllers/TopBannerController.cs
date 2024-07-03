using ContactUs.Business1.Admin.Banners.TopBanners.Abstract;
using ContactUs.Business1.Admin.Banners.TopBanners.Concrete;
using ContactUs.DataAccess1.Admin.Banners.TopBanners;
using ContactUs.DataAccess1.Admin.Banners.TopBanners.Concrete;
using ContactUs.Entities1.Admin.Banners;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopBannerController : ControllerBase
    {
        private ITBannerService _bannerService;
        public TopBannerController()
        {
            _bannerService = new TBannerManager(new TBannerRepository(new TopBannerDbContext()));
        }
        [HttpGet]
        public List<TopBanner> Get()
        {
            return _bannerService.GetAllTopBanners().Result;
        }
        [HttpGet("{id}")]
        public TopBanner Get(int id)
        {
            return _bannerService.GetTopBannerById(id).Result;
        }
        [HttpPost]
        public TopBanner Post([FromBody] TopBanner topBanner)
        {
            return _bannerService.AddTopBanner(topBanner).Result;
        }
        [HttpPut]
        public TopBanner Put([FromBody] TopBanner topBanner)
        {
            return _bannerService.UpdateTopBanner(topBanner).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bannerService.DeleteTopBanner(id);
        }
    }
}
