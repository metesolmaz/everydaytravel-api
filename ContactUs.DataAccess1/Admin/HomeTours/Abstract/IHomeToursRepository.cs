using ContactUs.Entities1.Admin.HomeTours;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.HomeTours.Abstract
{
    public interface IHomeToursRepository
    {
        Task<List<Entities1.Admin.HomeTours.HomeTours>> GetAllHomeTours(int langId);
        Task<Entities1.Admin.HomeTours.HomeTours> GetHomeToursById(int id);
        Task<Entities1.Admin.HomeTours.HomeTours> AddHomeTours(Entities1.Admin.HomeTours.HomeTours tours);
        Task<Entities1.Admin.HomeTours.HomeTours> UpdateHomeTours(Entities1.Admin.HomeTours.HomeTours tours);
        void DeleteHomeTours(int id);
    }
}
