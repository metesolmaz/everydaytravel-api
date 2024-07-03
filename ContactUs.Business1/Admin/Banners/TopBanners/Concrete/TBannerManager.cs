using ContactUs.Business1.Admin.Banners.TopBanners.Abstract;
using ContactUs.DataAccess1.Admin.Banners.TopBanners.Abstract;
using ContactUs.Entities1.Admin.Banners;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Banners.TopBanners.Concrete
{
    public class TBannerManager : ITBannerService
    {
        private ITBannerRepository _bannerRepository;
        public TBannerManager(ITBannerRepository bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }
        public Task<TopBanner> AddTopBanner(TopBanner topBanner)
        {
            return _bannerRepository.AddTopBanner(topBanner);
        }

        public void DeleteTopBanner(int id)
        {
            _bannerRepository.DeleteTopBanner(id);
        }
        public Task<List<TopBanner>> GetAllTopBanners()
        {
            return _bannerRepository.GetAllTopBanners();
        }

        public Task<TopBanner> GetTopBannerById(int id)
        {
            if (id > 1)
            {
                return _bannerRepository.GetTopBannerById(id);
            }
            throw new Exception("Id can not be less than 1");
        }

        public Task<TopBanner> UpdateTopBanner(TopBanner topBanner)
        {
            return _bannerRepository.UpdateTopBanner(topBanner);
        }
    }
}
