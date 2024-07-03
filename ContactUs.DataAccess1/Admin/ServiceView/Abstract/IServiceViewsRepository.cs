using ContactUs.Entities1.Admin.ServiceView;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.ServiceView.Abstract
{
    public interface IServiceViewsRepository
    {
        Task<List<ServiceViews>> GetAllServiceView(int langId);
        Task<ServiceViews> GetServiceViewById(int id);
        Task<ServiceViews> AddServiceView(ServiceViews serviceView);
        Task<ServiceViews> UpdateServiceView(ServiceViews serviceView);
        void DeleteServiceView(int id);
    }
}