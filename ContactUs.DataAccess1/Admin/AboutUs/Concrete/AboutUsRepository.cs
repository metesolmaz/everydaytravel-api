using ContactUs.DataAccess1.Admin.AboutUs.Abstract;
using ContactUs.Entities1.Admin.AboutUs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.AboutUs.Concrete
{
    public class AboutUsRepository : IAboutUsRepository
    {
        private readonly AboutUsDbContext _aboutUs;
        public AboutUsRepository(AboutUsDbContext aboutUs)
        {
            _aboutUs = aboutUs;
        }
        public async Task<About> AddAbout(About about)
        {
            await _aboutUs.About.AddAsync(about);
            await _aboutUs.SaveChangesAsync();
            return about;
        }

        public void DeleteAbout(int id)
        {
            _aboutUs.About.Remove(new About { id = id });
            _aboutUs.SaveChanges();
        }

        public async Task<About> GetAboutById(int id)
        {
            return await _aboutUs.About.FindAsync(id);
        }

        public async Task<List<About>> GetAllAbouts(int langId)
        {
            return await _aboutUs.About.Where(x => x.LanguageId == langId).ToListAsync();
        }

        public async Task<About> UpdateAbout(About about)
        {
            _aboutUs.About.Update(about);
            await _aboutUs.SaveChangesAsync();
            return about;
        }
    }
}
