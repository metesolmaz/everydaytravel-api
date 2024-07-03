using ContactUs.Business1.Admin.ServiceView.Abstract;
using ContactUs.DataAccess1.Admin.Services.Abstract;
using ContactUs.DataAccess1.Admin.Services.Concrete;
using ContactUs.DataAccess1.Admin.ServiceView.Abstract;
using ContactUs.Entities1.Admin.ServiceView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.ServiceView.Concrete
{
    public class ServiceViewsManager : IServiceViewsService
    {
        private IServiceViewsRepository _serviceViewRepository;

        public ServiceViewsManager(IServiceViewsRepository serviceViewRepository)
        {
            _serviceViewRepository = serviceViewRepository;
        }
        
        public Task<ServiceViews> AddServiceView(ServiceViews serviceView)
        {
            return _serviceViewRepository.AddServiceView(serviceView);
        }

        public void DeleteServiceView(int id)
        {
            _serviceViewRepository.DeleteServiceView(id); 
        }

        public Task<List<ServiceViews>> GetAllServiceView(int langId)
        {
            return _serviceViewRepository.GetAllServiceView(langId);
        }

        public Task<ServiceViews> GetServiceViewById(int id)
        {
            return _serviceViewRepository.GetServiceViewById(id); 
        }

        public Task<ServiceViews> UpdateServiceView(ServiceViews serviceView)
        {
            return _serviceViewRepository.UpdateServiceView(serviceView);
        
        }
    }
}
