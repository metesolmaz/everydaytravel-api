using ContactUs.Entities1.ContactUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess.Abstract
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetAllCustomers();
        Task<Contact> GetCustomerById(int id);
        Task<Contact> AddCustomer(Contact contact);
        Task<Contact> UpdateCustomer(Contact contact);
        void DeleteCustomer(int id);
    }
}
