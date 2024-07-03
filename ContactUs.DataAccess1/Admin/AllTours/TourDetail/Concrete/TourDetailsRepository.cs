using ContactUs.DataAccess1.Admin.AllTours.TourDetail.Abstract;
using ContactUs.Entities1.Admin.AllTours;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.AllTours.TourDetail.Concrete
{
    public  class TourDetailsRepository : ITourDetailsRepository
    {
        private readonly TourDetailsDbContext _tourDetails;
        public TourDetailsRepository(TourDetailsDbContext tourDetails)
        {
            _tourDetails = tourDetails;
        }
        public async Task<TourDetails> AddTourDetails(TourDetails tourDetails)
        {
            await _tourDetails.TourDetails.AddAsync(tourDetails);
            await _tourDetails.SaveChangesAsync();
            return tourDetails;
        }

        public void DeleteTourDetails(int id)
        {
            _tourDetails.TourDetails.Remove(new TourDetails { id = id });
            _tourDetails.SaveChanges();
        }

        public async Task<List<TourDetails>> GetAllTourDetails(int langId)
        {
            return await _tourDetails.TourDetails.Where(x => x.LanguageId == langId).ToListAsync();
        }

        public async Task<List<TourDetails>> GetTourDetailsPage(int tourId,int langId)
        {
            return await _tourDetails.TourDetails.Where(x => x.TourId == tourId && x.LanguageId == langId).ToListAsync();
        }
        public async Task<List<TourDetails>> GetTourDetailsPopular(bool ısPopular, int langId)
        {
            return await _tourDetails.TourDetails.Where(x => x.ısPopular == true && x.LanguageId == langId).ToListAsync();
        }        

        public async Task<TourDetails> GetTourDetailsById(int tourId)
        {
            return await _tourDetails.TourDetails.FirstOrDefaultAsync(x => x.id == tourId);
        }

        public async Task<TourDetails> UpdateTourDetails(TourDetails tourDetails)
        {
            _tourDetails.TourDetails.Update(tourDetails);
            await _tourDetails.SaveChangesAsync();
            return tourDetails;
        }
    }
}
