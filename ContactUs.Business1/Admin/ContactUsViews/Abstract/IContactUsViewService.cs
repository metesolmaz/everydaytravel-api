using ContactUs.Entities1.Admin.ContactUsViews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.ContactUsViews.Abstract
{
    public  interface IContactUsViewService
    {
        Task<ContactUsView> AddContactUsView(ContactUsView contactUsView);
        Task<ContactUsView> UpdateContactUsView(ContactUsView contactUsView);
        Task<List<ContactUsView>> GetAllContactUsViews(int langId);
        Task<ContactUsView> GetContactUsViewById(int id);
        void DeleteContactUsView(int id);
    }
}
