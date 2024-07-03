using ContactUs.Business1.Admin.AllTours.MainTour.Abstract;
using ContactUs.DataAccess1.Admin.AllTours.MainTour.Abstract;
using ContactUs.Entities1.Admin.AllTours;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.AllTours.MainTour.Concrete
{
    public class MainTourManager : IMainTourService
    {
        private  IMainToursRepository _mainTourRepository;
        public MainTourManager(IMainToursRepository mainTourRepository)
        {
            _mainTourRepository = mainTourRepository;
        }
        public Task<List<MainTours>> GetAllMainTours(int langId)
        {
            return _mainTourRepository.GetAllMainTours(langId);
        }
        public Task<MainTours> GetMainToursById(int id)
        {
            return _mainTourRepository.GetMainToursById(id);
        }
        public Task<MainTours> AddMainTours(MainTours mainTour)
        {
            return _mainTourRepository.AddMainTours(mainTour);
        }
        public Task<MainTours> UpdateMainTours(MainTours mainTour)
        {
            return _mainTourRepository.UpdateMainTours(mainTour);
        }
        public void DeleteMainTours(int id)
        {
            _mainTourRepository.DeleteMainTours(id);
        }
    }
}
