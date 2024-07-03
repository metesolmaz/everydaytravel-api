using ContactUs.Business1.Admin.AboutUs.Abstract;
using ContactUs.DataAccess1.Admin.AboutUs.Abstract;
using ContactUs.Entities1.Admin.AboutUs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.AboutUs.Concrete
{
    public class AboutUsManager : IAboutUsService
    {
        private IAboutUsRepository _aboutUsRepository;

        public AboutUsManager(IAboutUsRepository aboutURepository)
        {
            _aboutUsRepository = aboutURepository;
        }
        public Task<About> AddAbout(About about)
        {
            return _aboutUsRepository.AddAbout(about);
        }
        public Task<About> UpdateAbout(About about)
        {
            return _aboutUsRepository.UpdateAbout(about);
        }
        public Task<List<About>> GetAllAbouts(int langId)
        {
            return _aboutUsRepository.GetAllAbouts(langId);
        }
        public Task<About> GetAboutById(int id)
        {
            return _aboutUsRepository.GetAboutById(id);
        }
        public void DeleteAbout(int id)
        {
            _aboutUsRepository.DeleteAbout(id);
        }
    }
}
