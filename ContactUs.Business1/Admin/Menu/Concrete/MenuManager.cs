using ContactUs.Business1.Admin.Menu.Abstract;
using ContactUs.DataAccess1.Admin.Services.Abstract;
using ContactUs.Entities1.Admin.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Menu.Concrete
{
    public class MenuManager : IMenuService
    {
        private IMenuRepository _menuRepository;

        public MenuManager(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public Task<List<HorizontalNavbar>> GetAllMenu(int langId)
        {
            return _menuRepository.GetAllMenu(langId);
        }
        public Task<HorizontalNavbar> GetMenuById(int id)
        {
            if (id > 0)
            {
                return _menuRepository.GetMenuById(id);
            }
            throw new Exception("Id can not be less than 1");
        }
        public Task<HorizontalNavbar> AddMenu(HorizontalNavbar menu)
        {
            return _menuRepository.AddMenu(menu);
        }
        public Task<HorizontalNavbar> UpdateMenu(HorizontalNavbar menu)
        {
            return _menuRepository.UpdateMenu(menu);
        }
        void IMenuService.DeleteMenu(int id)
        {
            _menuRepository.DeleteMenu(id);
        }
    }
}
