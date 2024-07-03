using ContactUs.Entities1.Admin.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Menu.Abstract
{
    public interface IMenuService
    {
        Task<List<HorizontalNavbar>> GetAllMenu(int langId);
        Task<HorizontalNavbar> GetMenuById(int id);
        Task<HorizontalNavbar> AddMenu(HorizontalNavbar menu);
        Task<HorizontalNavbar> UpdateMenu(HorizontalNavbar menu);
        void DeleteMenu(int id);
    }
}
