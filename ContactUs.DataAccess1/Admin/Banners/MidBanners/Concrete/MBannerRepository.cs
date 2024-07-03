using ContactUs.DataAccess1.Admin.Banners.MidBanners.Abstract;
using ContactUs.Entities1.Admin.Banners;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.Banners.MidBanners.Concrete
{
    public class MBannerRepository : IMBannerRepository
    {
        private readonly MidBannerDbContext _midBanner;
        public MBannerRepository(MidBannerDbContext midBanner)
        {
            _midBanner = midBanner;
        }
        public async Task<MidBanner> AddMidBanner(MidBanner midBanner)
        {
            await _midBanner.MidBanner.AddAsync(midBanner);
            await _midBanner.SaveChangesAsync();
            return midBanner;
        }

        public void DeleteMidBanner(int id)
        {
            _midBanner.MidBanner.Remove(new MidBanner { id = id });
            _midBanner.SaveChanges();
        }

        public async Task<List<MidBanner>> GetAllMidBanners(int langId)
        {
            return await _midBanner.MidBanner.Where(x => x.LanguageId == langId).ToListAsync();
        }

        public async Task<MidBanner> GetMidBannerById(int id)
        {
            if (id > 0)
            {
                return await _midBanner.MidBanner.FirstOrDefaultAsync(x => x.id == id);
            }
            throw new Exception("Id can not be less than 1");
        }

        public async Task<MidBanner> UpdateMidBanner(MidBanner midBanner)
        {
            _midBanner.MidBanner.Update(midBanner);
            await _midBanner.SaveChangesAsync();
            return midBanner;
        }
    }
}
