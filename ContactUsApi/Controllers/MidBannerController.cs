using ContactUs.Business1.Admin.Banners.MidBanners.Abstract;
using ContactUs.Business1.Admin.Banners.MidBanners.Concrete;
using ContactUs.DataAccess1.Admin.Banners.MidBanners;
using ContactUs.DataAccess1.Admin.Banners.MidBanners.Concrete;
using ContactUs.Entities1.Admin.Banners;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MidBannerController : ControllerBase
    {
        private IMBannerService _mbannerService;
        public MidBannerController()
        {
            _mbannerService = new MBannerManager(new MBannerRepository(new MidBannerDbContext()));
        }
        [HttpGet("all/{langid}")]
        public List<MidBanner> GetAllMidBanners(int langId)
        {
            return _mbannerService.GetAllMidBanners(langId).Result;
        }
        [HttpGet("{id}")]
        public MidBanner Get(int id)
        {
            return _mbannerService.GetMidBannerById(id).Result;
        }
        [HttpPost]
        public MidBanner Post([FromBody] MidBanner midBanner)
        {
            return _mbannerService.AddMidBanner(midBanner).Result;
        }
        [HttpPut]
        public MidBanner Put([FromBody] MidBanner midBanner)
        {
            return _mbannerService.UpdateMidBanner(midBanner).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mbannerService.DeleteMidBanner(id);
        }
    }
}
