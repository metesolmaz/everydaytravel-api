using ContactUs.Business1.Admin.Sliders.Abstract;
using ContactUs.Business1.Admin.Sliders.Concrete;
using ContactUs.DataAccess1.Admin.Sliders;
using ContactUs.DataAccess1.Admin.Sliders.Concrete;
using ContactUs.Entities1.Admin.Sliders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private ISliderService _sliderService;
        public SliderController()
        {
            _sliderService = new SliderManager(new SliderRepository(new SliderDbContext()));
        }
        [HttpGet("all/{langid}")]
        public List<Slider> GetAllSlider(int langId)
        {
            return _sliderService.GetAllSliders(langId).Result;
        }
        [HttpGet("{id}")]
        public Slider Get(int id)
        {
            return _sliderService.GetSliderById(id).Result;
        }
        [HttpPost]
        public Slider Post([FromBody] Slider slider)
        {
            return _sliderService.AddSlider(slider).Result;
        }
        [HttpPut]
        public Slider Put([FromBody] Slider slider)
        {
            return _sliderService.UpdateSlider(slider).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _sliderService.DeleteSlider(id);
        }

    }
}
