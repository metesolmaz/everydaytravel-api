using ContactUs.Entities1.Admin.Banners;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Banners.TopBanners.Abstract
{
    public interface ITBannerService
    {
        Task<List<TopBanner>> GetAllTopBanners();
        Task<TopBanner> GetTopBannerById(int id);
        Task<TopBanner> AddTopBanner(TopBanner topBanner);
        Task<TopBanner> UpdateTopBanner(TopBanner topBanner);
        void DeleteTopBanner(int id);
    }
}
