using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ContactUs.Entities1.Admin.Banners;

namespace ContactUs.DataAccess1.Admin.Banners.MidBanners.Abstract
{
    public interface IMBannerRepository
    {
        Task<List<MidBanner>> GetAllMidBanners(int langId);
        Task<MidBanner> GetMidBannerById(int id);
        Task<MidBanner> AddMidBanner(MidBanner midBanner);
        Task<MidBanner> UpdateMidBanner(MidBanner midBanner);
        void DeleteMidBanner(int id);
    }
}
