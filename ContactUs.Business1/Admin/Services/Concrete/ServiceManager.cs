using ContactUs.Business1.Admin.Services.Abstract;
using ContactUs.DataAccess1.Admin.Services.Abstract;
using ContactUs.DataAccess1.Admin.ServiceView.Abstract;
using ContactUs.Entities1.Admin.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Services.Concrete
{
    public class ServiceManager : IServicesService
    {
        private IServiceRepository _serviceRepository;

        public ServiceManager(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public Task<Service> AddService(Service service)
        {
            return _serviceRepository.AddService(service);
        }

        public void DeleteService(int id)
        {
            _serviceRepository.DeleteService(id);
        }

        public Task<List<Service>> GetAllService(int langId)
        {
            return _serviceRepository.GetAllService(langId);
        }

        public Task<Service> GetServiceById(int id)
        {
            return _serviceRepository.GetServiceById(id);
        }

        public Task<Service> UpdateService(Service service)
        {
            return _serviceRepository.UpdateService(service);
        }
    }
}
