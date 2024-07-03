using ContactUs.Entities1.Admin.ToursViews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.ToursViews.Abstract
{
    public interface IToursViewRepository
    {
        Task<List<ToursView>> GetAllToursView(int langId);
        Task<ToursView> GetToursViewById(int id);
        Task<ToursView> AddToursView(ToursView toursView);
        Task<ToursView> UpdateToursView(ToursView toursView);
        void DeleteToursView(int id);
    }
}
