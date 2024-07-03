using ContactUs.Entities1.Admin.ServiceView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.ServiceView.Abstract
{
    public interface IServiceViewsService
    {
        Task<List<ServiceViews>> GetAllServiceView(int langId);
        Task<ServiceViews> GetServiceViewById(int id);
        Task<ServiceViews> AddServiceView(ServiceViews serviceView);
        Task<ServiceViews> UpdateServiceView(ServiceViews serviceView);
        void DeleteServiceView(int id);
    }
}
