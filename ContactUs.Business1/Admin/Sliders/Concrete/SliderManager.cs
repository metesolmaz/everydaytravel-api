using ContactUs.Business1.Admin.Sliders.Abstract;
using ContactUs.DataAccess1.Admin.Sliders.Abstract;
using ContactUs.Entities1.Admin.Sliders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Sliders.Concrete
{
    public class SliderManager : ISliderService
    {
        private ISliderRepository _sliderRepository;

        public SliderManager(ISliderRepository sliderRepository)
        {
            _sliderRepository = sliderRepository;
        }
        public Task<Slider> AddSlider(Slider slider)
        {
            return _sliderRepository.AddSlider(slider);
        }
        public void DeleteSlider(int id)
        {
            _sliderRepository.DeleteSlider(id);
        }
        public Task<List<Slider>> GetAllSliders(int langId)
        {
            return _sliderRepository.GetAllSliders(langId);
        }
        public Task<Slider> GetSliderById(int id)
        {
            if (id > 0)
            {
                return _sliderRepository.GetSliderById(id);
            }
            throw new Exception("Id can not be less than 1");

        }
        public Task<Slider> UpdateSlider(Slider slider)
        {
            return _sliderRepository.UpdateSlider(slider);
        }
    }
}
