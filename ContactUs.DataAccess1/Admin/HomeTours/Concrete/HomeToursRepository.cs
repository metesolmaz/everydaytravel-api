using ContactUs.DataAccess1.Admin.HomeTours.Abstract;
using ContactUs.Entities1.Admin.HomeTours;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.HomeTours.Concrete
{
    public class HomeToursRepository : IHomeToursRepository
    {
        private HomeToursDbContext _homeTours;
        public HomeToursRepository(HomeToursDbContext tours)
        {
            _homeTours = tours;
        }
        public async Task<Entities1.Admin.HomeTours.HomeTours> AddHomeTours(Entities1.Admin.HomeTours.HomeTours tours)
        {
             _homeTours.HomeTours.Add(tours);
            await _homeTours.SaveChangesAsync();
            return tours;
        }

        public void DeleteHomeTours(int id)
        {
            _homeTours.HomeTours.Remove(new Entities1.Admin.HomeTours.HomeTours { id = id });
            _homeTours.SaveChanges();
        }

        public async Task<List<Entities1.Admin.HomeTours.HomeTours>> GetAllHomeTours(int langId)
        {
               return await _homeTours.HomeTours.Where(x => x.LanguageId == langId).ToListAsync();
        }

        public async Task<Entities1.Admin.HomeTours.HomeTours> GetHomeToursById(int id)
        {
            if (id > 0)
            {
                return await _homeTours.HomeTours.FirstOrDefaultAsync(x => x.id == id);
            }
            throw new Exception("Id can not be less than 1");
        }

        public async Task<Entities1.Admin.HomeTours.HomeTours> UpdateHomeTours(Entities1.Admin.HomeTours.HomeTours tours)
        {
            _homeTours.HomeTours.Update(tours);
            await _homeTours.SaveChangesAsync();
            return tours;
        }
    }
}
