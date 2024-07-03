using ContactUs.DataAccess1.Admin.Banners.TopBanners.Abstract;
using ContactUs.Entities1.Admin.Banners;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.Banners.TopBanners.Concrete
{
    public class TBannerRepository : ITBannerRepository
    {
        private readonly TopBannerDbContext _topBanner;
        public TBannerRepository(TopBannerDbContext topBanner)
        {
            _topBanner = topBanner;
        }
        public async Task<List<TopBanner>> GetAllTopBanners()
        {
            return await _topBanner.TopBanner.ToListAsync();
        }
        public async Task<TopBanner> GetTopBannerById(int id)
        {
            if (id > 0)
            {
                return await _topBanner.TopBanner.FirstOrDefaultAsync(x => x.id == id);
            }
            throw new Exception("Id can not be less than 1");
        }
        public async Task<TopBanner> AddTopBanner(TopBanner topBanner)
        {
            await _topBanner.TopBanner.AddAsync(topBanner);
            await _topBanner.SaveChangesAsync();
            return topBanner;
        }

        public void DeleteTopBanner(int id)
        {
            _topBanner.TopBanner.Remove(new TopBanner { id = id });
            _topBanner.SaveChanges();
        }
        public async Task<TopBanner> UpdateTopBanner(TopBanner topBanner)
        {
            _topBanner.TopBanner.Update(topBanner);
            await _topBanner.SaveChangesAsync();
            return topBanner;
        }
    }
}
