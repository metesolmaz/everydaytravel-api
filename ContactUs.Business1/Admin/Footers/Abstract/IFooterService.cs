using ContactUs.Entities1.Admin.Footers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Footers.Abstract
{
    public interface IFooterService
    {
        Task<List<Footer>> GetAllFooters(int langId);
        Task<Footer> GetFooterById(int id);
        Task<Footer> AddFooter(Footer footer);
        Task<Footer> UpdateFooter(Footer footer);
        void DeleteFooter(int id);
    }
}
