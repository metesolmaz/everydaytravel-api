using ContactUs.Business1.Admin.HomeTours.Abstract;
using ContactUs.DataAccess1.Admin.HomeTours.Abstract;
using ContactUs.Entities1.Admin.HomeTours;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.HomeTours.Concrete
{
    public class HomeToursManager : IHomeToursService
    {
        private  IHomeToursRepository _homeToursRepository;
        public HomeToursManager(IHomeToursRepository homeToursRepository)
        {
            _homeToursRepository = homeToursRepository;
        }
        public Task<Entities1.Admin.HomeTours.HomeTours> AddHomeTours(Entities1.Admin.HomeTours.HomeTours tours)
        {
            return _homeToursRepository.AddHomeTours(tours);
        }

        public void DeleteHomeTours(int id)
        {
            _homeToursRepository.DeleteHomeTours(id);
        }

        public Task<List<Entities1.Admin.HomeTours.HomeTours>> GetAllHomeTours(int langId)
        {
            return _homeToursRepository.GetAllHomeTours( langId);
        }

        public Task<Entities1.Admin.HomeTours.HomeTours> GetHomeToursById(int id)
        {
            return _homeToursRepository.GetHomeToursById(id);
        }

        public Task<Entities1.Admin.HomeTours.HomeTours> UpdateHomeTours(Entities1.Admin.HomeTours.HomeTours tours)
        {
            return _homeToursRepository.UpdateHomeTours(tours);
        }
    }
}
