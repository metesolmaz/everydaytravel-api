using ContactUs.Entities1.Admin.Banners;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Banners.MidBanners.Abstract
{
    public interface IMBannerService
    {
        Task<List<MidBanner>> GetAllMidBanners(int langId);
        Task<MidBanner> GetMidBannerById(int id);
        Task<MidBanner> AddMidBanner(MidBanner midBanner);
        Task<MidBanner> UpdateMidBanner(MidBanner midBanner);
        void DeleteMidBanner(int id);
    }
}
