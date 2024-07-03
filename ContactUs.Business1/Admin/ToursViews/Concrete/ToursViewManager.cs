using ContactUs.Business1.Admin.ToursViews.Abstract;
using ContactUs.DataAccess1.Admin.ToursViews.Abstract;
using ContactUs.Entities1.Admin.ToursViews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.ToursViews.Concrete
{
    public class ToursViewManager : IToursViewService
    {
        private IToursViewRepository _toursViewRepository;

        public ToursViewManager(IToursViewRepository toursViewRepository)
        {
            _toursViewRepository = toursViewRepository;
        }

        public Task<ToursView> AddToursView(ToursView toursView)
        {
            return _toursViewRepository.AddToursView(toursView);
        }

        public void DeleteToursView(int id)
        {
            _toursViewRepository.DeleteToursView(id);
        }

        public Task<List<ToursView>> GetAllToursView(int langId)
        {
            return _toursViewRepository.GetAllToursView(langId);
        }

        public Task<ToursView> GetToursViewById(int id)
        {
            return _toursViewRepository.GetToursViewById(id);
        }

        public Task<ToursView> UpdateToursView(ToursView toursView)
        {
            return _toursViewRepository.UpdateToursView(toursView);
        }
    }
}
