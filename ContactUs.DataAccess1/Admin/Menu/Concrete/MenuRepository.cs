using ContactUs.DataAccess1.Admin.Services.Abstract;
using ContactUs.Entities1.Admin.Menu;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.Services.Concrete
{
    public class MenuRepository : IMenuRepository
    {
        private readonly MenuDbContext _menu;
        public MenuRepository(MenuDbContext menu)
        {
            _menu = menu;
        }
        public async Task<List<HorizontalNavbar>> GetAllMenu(int langId)
        {
            return await _menu.HorizontalNavbar.Where(s => s.LanguageId == langId).ToListAsync();
        }
        public async Task<HorizontalNavbar> GetMenuById(int id)
        {
            if (id > 0)
            {
                return await _menu.HorizontalNavbar.FirstOrDefaultAsync(x => x.id == id);
            }
            throw new Exception("Id can not be less than 1");
        }
        public async Task<HorizontalNavbar> AddMenu(HorizontalNavbar menu)
        {
            await _menu.HorizontalNavbar.AddAsync(menu);
            await _menu.SaveChangesAsync();
            return menu;
        }
        public async Task<HorizontalNavbar> UpdateMenu(HorizontalNavbar menu)
        {
            _menu.HorizontalNavbar.Update(menu);
            await _menu.SaveChangesAsync();
            return menu;
        }
        public void DeleteMenu(int id)
        {
            _menu.HorizontalNavbar.Remove(new HorizontalNavbar { id = id });
            _menu.SaveChanges();
        }
    }
}
