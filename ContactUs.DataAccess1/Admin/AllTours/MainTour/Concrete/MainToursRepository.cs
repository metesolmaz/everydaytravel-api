using ContactUs.DataAccess1.Admin.AllTours.MainTour.Abstract;
using ContactUs.Entities1.Admin.AllTours;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.AllTours.MainTour.Concrete
{
    public  class MainToursRepository :IMainToursRepository
    {
        private readonly MainToursDbContext _mainTour;
        public MainToursRepository(MainToursDbContext mainTour)
        {
            _mainTour = mainTour;
        }
        public void DeleteMainTours(int id)
        {
            _mainTour.MainTours.Remove(new MainTours { id = id });
            _mainTour.SaveChanges();
        }

            public async Task<MainTours> GetMainToursById(int id)
            {
                return await _mainTour.MainTours.FindAsync(id);
            }

        public async Task<List<MainTours>> GetAllMainTours(int langId)
        {
            return await _mainTour.MainTours.Where(x => x.LanguageId == langId).ToListAsync();
        }

        public async Task<MainTours> AddMainTours(MainTours tours)
        {

            await _mainTour.MainTours.AddAsync(tours);
            await _mainTour.SaveChangesAsync();
            return tours;
        }

        public async Task<MainTours> UpdateMainTours(MainTours tours)
        {
            _mainTour.MainTours.Update(tours);
            await _mainTour.SaveChangesAsync();
            return tours;
        }
    }
}
