using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ContactUs.Entities1.Admin.Banners;

namespace ContactUs.DataAccess1.Admin.Banners.TopBanners.Abstract
{
    public interface ITBannerRepository
    {
        Task<List<TopBanner>> GetAllTopBanners();
        Task<TopBanner> GetTopBannerById(int id);
        Task<TopBanner> AddTopBanner(TopBanner topBanner);
        Task<TopBanner> UpdateTopBanner(TopBanner topBanner);
        void DeleteTopBanner(int id);
    }
}
