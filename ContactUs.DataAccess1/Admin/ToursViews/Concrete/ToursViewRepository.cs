using ContactUs.DataAccess1.Admin.ToursViews.Abstract;
using ContactUs.Entities1.Admin.ToursViews;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.ToursViews.Concrete
{
    public class ToursViewRepository : IToursViewRepository
    {
        private readonly ToursViewDbContext _toursView;
        public ToursViewRepository(ToursViewDbContext toursView)
        {
            _toursView = toursView;
        }

        public async Task<ToursView> AddToursView(ToursView toursView)
        {
            _toursView.Add(toursView);
            await _toursView.SaveChangesAsync();
            return toursView;
        }

        public void DeleteToursView(int id)
        {
            _toursView.ToursView.Remove(new ToursView { id = id });
            _toursView.SaveChanges();
        }

        public async Task<List<ToursView>> GetAllToursView(int langId)
        {
            return await _toursView.ToursView.Where(x => x.LanguageId == langId).ToListAsync();
        }

        public async Task<ToursView> GetToursViewById(int id)
        {
            if (id > 0)
            {
                return await _toursView.ToursView.FirstOrDefaultAsync(x => x.id == id);
            }
            throw new Exception("Id can not be less than 1");
        }
        
        public async Task<ToursView> UpdateToursView(ToursView toursView)
        {
            _toursView.ToursView.Update(toursView);
            await _toursView.SaveChangesAsync();
            return toursView;
        }
    }
}
