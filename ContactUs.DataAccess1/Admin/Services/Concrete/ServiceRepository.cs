using ContactUs.DataAccess1.Admin.Services.Abstract;
using ContactUs.Entities1.Admin.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.Services.Concrete
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ServiceDbContext _service;
        public ServiceRepository(ServiceDbContext service)
        {
            _service = service;
        }
        public void DeleteService(int id)
        {
            _service.Service.Remove(new Service { id = id });
            _service.SaveChanges();
        }

        public async Task<List<Service>> GetAllService(int langId)
        {
            return await _service.Service.Where(s => s.LanguageId == langId).ToListAsync();
        }

        public async Task<Service> GetServiceById(int id)
        {
            if (id > 0)
            {
                return await _service.Service.FirstOrDefaultAsync(x => x.id == id);
            }
            throw new Exception("Id can not be less than 1");
        }

        public async Task<Service> AddService(Service service)
        {
            await _service.Service.AddAsync(service);
            await _service.SaveChangesAsync();
            return service;
        }

        public async  Task<Service> UpdateService(Service service)
        {
            _service.Service.Update(service);
            await _service.SaveChangesAsync();
            return service;
        }
    }
}
