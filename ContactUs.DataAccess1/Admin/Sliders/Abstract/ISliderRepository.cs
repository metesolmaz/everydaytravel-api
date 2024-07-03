using ContactUs.Entities1.Admin.Sliders;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.Sliders.Abstract
{
    public interface ISliderRepository
    {
        Task<List<Slider>> GetAllSliders(int langId);
        Task<Slider> GetSliderById(int id);
        Task<Slider> AddSlider(Slider slider);
        Task<Slider> UpdateSlider(Slider slider);
        void DeleteSlider(int id);
    }
}
