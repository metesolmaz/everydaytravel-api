using ContactUs.Business1.Admin.Banners.MidBanners.Abstract;
using ContactUs.DataAccess1.Admin.Banners.MidBanners.Abstract;
using ContactUs.Entities1.Admin.Banners;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Banners.MidBanners.Concrete
{
    public class MBannerManager : IMBannerService
    {
        private IMBannerRepository _mbannerRepository;
        public MBannerManager(IMBannerRepository mbannerRepository)
        {
            _mbannerRepository = mbannerRepository;
        }
        public Task<MidBanner> AddMidBanner(MidBanner midBanner)
        {
            return _mbannerRepository.AddMidBanner(midBanner);
        }

        public void DeleteMidBanner(int id)
        {
            _mbannerRepository.DeleteMidBanner(id);
        }

        public Task<List<MidBanner>> GetAllMidBanners(int langId)
        {
            return _mbannerRepository.GetAllMidBanners(langId);
        }

        public Task<MidBanner> GetMidBannerById(int id)
        {
            if (id > 1)
            {
                return _mbannerRepository.GetMidBannerById(id);
            }
            throw new Exception("Id can not be less than 1");
        }

        public Task<MidBanner> UpdateMidBanner(MidBanner midBanner)
        {
            return _mbannerRepository.UpdateMidBanner(midBanner);
        }
    }
}
