using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ContactUs.Entities1.Admin.Menu;

namespace ContactUs.DataAccess1.Admin.Services.Abstract
{
    public interface IMenuRepository
    {
        Task<List<HorizontalNavbar>> GetAllMenu(int langId);
        Task<HorizontalNavbar> GetMenuById(int id);
        Task<HorizontalNavbar> AddMenu(HorizontalNavbar menu);
        Task<HorizontalNavbar> UpdateMenu(HorizontalNavbar menu);
        void DeleteMenu(int id);
    }
}
