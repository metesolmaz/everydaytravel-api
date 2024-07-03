using ContactUs.DataAccess1.Admin.Sliders.Abstract;
using ContactUs.Entities1.Admin.Sliders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.Sliders.Concrete
{
    public class SliderRepository : ISliderRepository
    {
        private readonly SliderDbContext _slider;
        public SliderRepository(SliderDbContext slider)
        {
            _slider = slider;
        }

        public async Task<Slider> AddSlider(Slider slider)
        {
            _slider.Add(slider);
            await _slider.SaveChangesAsync();
            return slider;
        }

        public void DeleteSlider(int id)
        {
            _slider.Slider.Remove(new Slider { id = id });
            _slider.SaveChanges();
        }

        public async Task<List<Slider>> GetAllSliders(int langId)
        {
            return await _slider.Slider.Where(x => x.LanguageId == langId).ToListAsync();
        }

        public async Task<Slider> GetSliderById(int id)
        {
            if (id > 0)
            {
                return await _slider.Slider.FirstOrDefaultAsync(x => x.id == id);
            }
            throw new Exception("Id can not be less than 1");
        }

        public async Task<Slider> UpdateSlider(Slider slider)
        {
            _slider.Slider.Update(slider);
            await _slider.SaveChangesAsync();
            return slider;
        }
    }
}
