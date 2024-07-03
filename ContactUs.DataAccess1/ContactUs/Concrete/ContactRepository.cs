using ContactUs.DataAccess.Abstract;
using ContactUs.DataAccess1.ContactUs;
using ContactUs.Entities1.ContactUs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess.Concrete
{
    public class ContactRepository : IContactRepository
    {
        private readonly CustomerDbContext _context;
        public ContactRepository(CustomerDbContext context)
        {
            _context = context;
        }
        public async Task<List<Contact>> GetAllCustomers()
        {
            return await _context.Contacts.ToListAsync();
        }
        public async Task<Contact> GetCustomerById(int id)
        {
            return await _context.Contacts.FindAsync(id);
        }
        public async Task<Contact> AddCustomer(Contact contact)
        {
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
            return contact;
        }
        public async Task<Contact> UpdateCustomer(Contact contact)
        {
            _context.Contacts.Update(contact);
            await _context.SaveChangesAsync();
            return contact;
        }
        public void DeleteCustomer(int id)
        {
            var contact = _context.Contacts.Find(id);
            _context.Contacts.Remove(contact);
            _context.SaveChanges();
        }
    }
    
}
