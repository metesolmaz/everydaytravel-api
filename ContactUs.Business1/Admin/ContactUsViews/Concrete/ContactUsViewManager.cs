using ContactUs.Business1.Admin.ContactUsViews.Abstract;
using ContactUs.DataAccess1.Admin.ContactUsViews.Abstract;
using ContactUs.Entities1.Admin.ContactUsViews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.ContactUsViews.Concrete
{
    public class ContactUsViewManager : IContactUsViewService
    {
        private IContactUsViewRepository _contactUsViewRepository;

        public ContactUsViewManager(IContactUsViewRepository contactUsViewRepository)
        {
            _contactUsViewRepository = contactUsViewRepository;
        }

        public Task<ContactUsView> AddContactUsView(ContactUsView contactUsView)
        {
            return _contactUsViewRepository.AddContactUsView(contactUsView);
        }

        public void DeleteContactUsView(int id)
        {
            _contactUsViewRepository.DeleteContactUsView(id);
        }

        public Task<List<ContactUsView>> GetAllContactUsViews(int langId)
        {
            return _contactUsViewRepository.GetAllContactUsViews(langId);
        }

        public Task<ContactUsView> GetContactUsViewById(int id)
        {
            return _contactUsViewRepository.GetContactUsViewById(id);
        }

        public Task<ContactUsView> UpdateContactUsView(ContactUsView contactUsView)
        {
            return _contactUsViewRepository.UpdateContactUsView(contactUsView);
        }
    }
}
