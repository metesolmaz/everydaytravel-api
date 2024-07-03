using ContactUs.Entities1.Admin.ToursViews;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.ToursViews.Abstract
{
    public interface IToursViewService
    {
        Task<List<ToursView>> GetAllToursView(int langId);
        Task<ToursView> GetToursViewById(int id);
        Task<ToursView> AddToursView(ToursView toursView);
        Task<ToursView> UpdateToursView(ToursView toursView);
        void DeleteToursView(int id);
    }
}
