using ContactUs.Entities1.Admin.AllTours;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.AllTours.TourDetail.Abstract
{
    public  interface ITourDetailsRepository
    {
        Task<List<TourDetails>> GetAllTourDetails(int langId);
        Task<List<TourDetails>> GetTourDetailsPage(int tourId, int langId);
        Task<List<TourDetails>> GetTourDetailsPopular(bool ısPopular, int langId);
        Task<TourDetails> GetTourDetailsById(int tourId);
        Task<TourDetails> AddTourDetails(TourDetails tourDetails);
        Task<TourDetails> UpdateTourDetails(TourDetails tourDetails);
        void DeleteTourDetails(int id);
    }
}
