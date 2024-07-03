using ContactUs.Business1.Admin.Footers.Abstract;
using ContactUs.DataAccess1.Admin.Footers.Abstract;
using ContactUs.Entities1.Admin.Footers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Footers.Concrete
{
    public class FooterManager : IFooterService
    {
        private IFooterRepository _footerRepository;
        public FooterManager(IFooterRepository footerRepository)
        {
            _footerRepository = footerRepository;
        }
        public Task<List<Footer>> GetAllFooters(int langId)
        {
            return _footerRepository.GetAllFooters(langId);
        }
        public Task<Footer> GetFooterById(int id)
        {
            return _footerRepository.GetFooterById(id);
        }
        public Task<Footer> AddFooter(Footer footer)
        {
            return _footerRepository.AddFooter(footer);
        }
        public Task<Footer> UpdateFooter(Footer footer)
        {
            return _footerRepository.UpdateFooter(footer);
        }
        public void DeleteFooter(int id)
        {
            _footerRepository.DeleteFooter(id);
        }
    }
}
