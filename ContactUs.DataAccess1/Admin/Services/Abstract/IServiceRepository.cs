using ContactUs.Entities1.Admin.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.Services.Abstract
{
    public interface IServiceRepository
    {
        Task<List<Service>> GetAllService(int langId);
        Task<Service> GetServiceById(int id);
        Task<Service> AddService(Service service);
        Task<Service> UpdateService(Service service);
        void DeleteService(int id);
    }
}
