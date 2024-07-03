using ContactUs.DataAccess1.Admin.Services;
using ContactUs.DataAccess1.Admin.ServiceView.Abstract;
using ContactUs.Entities1.Admin.ServiceView;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.ServiceView.Concrete
{
    public class ServiceViewsRepository : IServiceViewsRepository
    {
        private readonly ServiceViewsDbContext _serviceViews;
        public ServiceViewsRepository(ServiceViewsDbContext serviceViews)
        {
            _serviceViews = serviceViews;
        }

        public async Task<ServiceViews> AddServiceView(ServiceViews serviceView)
        {
            await _serviceViews.ServiceViews.AddAsync(serviceView);
            await _serviceViews.SaveChangesAsync();
            return serviceView;
        }

        public void DeleteServiceView(int id)
        {
            _serviceViews.ServiceViews.Remove(new ServiceViews { id = id });
            _serviceViews.SaveChanges();
        }

        public async Task<List<ServiceViews>> GetAllServiceView(int langId)
        {
            return await _serviceViews.ServiceViews.Where(s => s.LanguageId == langId).ToListAsync();
        }

        public async Task<ServiceViews> GetServiceViewById(int id)
        {
            if (id > 0)
            {
                return await _serviceViews.ServiceViews.FirstOrDefaultAsync(x => x.id == id);
            }
            throw new Exception("Id can not be less than 1");
        }

        public async Task<ServiceViews> UpdateServiceView(ServiceViews serviceView)
        {
            _serviceViews.ServiceViews.Update(serviceView);
            await _serviceViews.SaveChangesAsync();
            return serviceView;
        }
    }
}
