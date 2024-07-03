using ContactUs.Business.Abstract;
using ContactUs.Business.Concrete;
using ContactUs.DataAccess.Concrete;
using ContactUs.DataAccess1.ContactUs;
using ContactUs.Entities1.ContactUs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ContactUsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private IContactService _contactService;
        public ContactUsController()
        {
            _contactService = new ContactManager(new ContactRepository(new CustomerDbContext()));
        }
        [HttpGet]
        public List<Contact> Get()
        {
            return _contactService.GetAllContacts().Result;
        }
        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return _contactService.GetContactById(id).Result;
        }
        [HttpPost]
        public Contact Post([FromBody] Contact contact)
        {
            return _contactService.AddContact(contact).Result;
        }
        [HttpPut]
        public Contact Put([FromBody] Contact contact)
        {
            return _contactService.UpdateContact(contact).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _contactService.DeleteContact(id);
        }

    }
}
