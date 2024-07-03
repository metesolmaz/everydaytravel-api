using ContactUs.DataAccess1.Admin.Footers.Abstract;
using ContactUs.Entities1.Admin.Footers;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.Footers.Concrete
{
    public class FooterRepository : IFooterRepository
    {
        private readonly FooterDbContext _footer;
        public FooterRepository(FooterDbContext footer)
        {
            _footer = footer;
        }
        public async Task<Footer> AddFooter(Footer footer)
        {
            await _footer.Footer.AddAsync(footer);
            await _footer.SaveChangesAsync();
            return footer;
        }

        public void DeleteFooter(int id)
        {
            _footer.Footer.Remove(new Footer { id = id });
            _footer.SaveChanges();
        }

        public async Task<List<Footer>> GetAllFooters(int langId)
        {
            return await _footer.Footer.Where(x => x.LanguageId == langId).ToListAsync();
        }

        public async Task<Footer> GetFooterById(int id)
        {
            return await _footer.Footer.Where(x => x.id == id).FirstOrDefaultAsync();
        }

        public async Task<Footer> UpdateFooter(Footer footer)
        {
            _footer.Footer.Update(footer);
            await _footer.SaveChangesAsync();
            return footer;
        }
    }
}
