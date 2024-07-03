using ContactUs.DataAccess1.Admin.ContactUsViews.Abstract;
using ContactUs.Entities1.Admin.ContactUsViews;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.ContactUsViews.Concrete
{
    public class ContactUsViewRepository : IContactUsViewRepository
    {
        private readonly ContactUsViewDbContext _contactUsView;
        public ContactUsViewRepository(ContactUsViewDbContext contactUsView)
        {
            _contactUsView = contactUsView;
        }
        public async Task<ContactUsView> AddContactUsView(ContactUsView contactUsView)
        {
            await _contactUsView.ContactUsView.AddAsync(contactUsView);
            await _contactUsView.SaveChangesAsync();
            return contactUsView;
        }

        public void DeleteContactUsView(int id)
        {
            _contactUsView.ContactUsView.Remove(new ContactUsView { id = id });
            _contactUsView.SaveChanges();
        }

        public async Task<List<ContactUsView>> GetAllContactUsViews(int langId)
        {
            return await _contactUsView.ContactUsView.Where(x => x.LanguageId == langId).ToListAsync();
        }

        public async Task<ContactUsView> GetContactUsViewById(int id)
        {
            return await _contactUsView.ContactUsView.FindAsync(id);
        }

        public async Task<ContactUsView> UpdateContactUsView(ContactUsView contactUsView)
        {
            _contactUsView.ContactUsView.Update(contactUsView);
            await _contactUsView.SaveChangesAsync();
            return contactUsView;
        }
    }
}
