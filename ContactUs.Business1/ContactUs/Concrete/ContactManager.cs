using ContactUs.Business.Abstract;
using ContactUs.DataAccess.Abstract;
using ContactUs.Entities1.ContactUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business.Concrete
{
    public class ContactManager: IContactService
    {
        private IContactRepository _contactRepository;
        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Task<List<Contact>> GetAllContacts()
        {
            return _contactRepository.GetAllCustomers();
        }

        public Task<Contact> GetContactById(int id)
        {
            if (id > 0)
            {
                return _contactRepository.GetCustomerById(id);
            }
            throw new Exception("Id can not be less than 1");
        }

        public Task<Contact> AddContact(Contact contact)
        {
            return _contactRepository.AddCustomer(contact);
        }

        public Task<Contact> UpdateContact(Contact contact)
        {
            return _contactRepository.UpdateCustomer(contact);
        }

        void IContactService.DeleteContact(int id)
        {
            _contactRepository.DeleteCustomer(id);
        }
    }
}
