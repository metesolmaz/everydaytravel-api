using ContactUs.Business1.Admin.AllTours.TourDetail.Abstract;
using ContactUs.DataAccess1.Admin.AllTours.TourDetail.Abstract;
using ContactUs.Entities1.Admin.AllTours;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.AllTours.TourDetail.Concrete
{
    public  class TourDetailsManager : ITourDetailsService
    {
        private readonly ITourDetailsRepository _tourDetailsRepository;

        public TourDetailsManager(ITourDetailsRepository tourDetailsRepository)
        {
            _tourDetailsRepository = tourDetailsRepository;
        }

        public Task<TourDetails> AddTourDetails(TourDetails tourDetails)
        {
            return _tourDetailsRepository.AddTourDetails(tourDetails);
        }

        public void DeleteTourDetails(int id)
        {
            _tourDetailsRepository.DeleteTourDetails(id);
        }

        public Task<List<TourDetails>> GetAllTourDetails(int langId)
        {
            return _tourDetailsRepository.GetAllTourDetails(langId);
        }

        public Task<TourDetails> GetTourDetailsById(int tourId)
        {
            return _tourDetailsRepository.GetTourDetailsById(tourId);
        }

        public Task<List<TourDetails>> GetTourDetailsPage(int tourId,int langId)
        {
            return _tourDetailsRepository.GetTourDetailsPage(tourId, langId);
        }
        public Task<List<TourDetails>> GetTourDetailsPopular(bool ısPopular, int langId)
        {
            return _tourDetailsRepository.GetTourDetailsPopular(ısPopular, langId);
        }

        public Task<TourDetails> UpdateTourDetails(TourDetails tourDetails)
        {
            return _tourDetailsRepository.UpdateTourDetails(tourDetails);
        }
    }
}
