using ContactUs.Entities1.Admin.Sliders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Sliders.Abstract
{
    public interface ISliderService
    {
        Task<List<Slider>> GetAllSliders(int langId);
        Task<Slider> GetSliderById(int id);
        Task<Slider> AddSlider(Slider slider);
        Task<Slider> UpdateSlider(Slider slider);
        void DeleteSlider(int id);
    }
}
