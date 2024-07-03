using ContactUs.Business1.Admin.ContactUsViews.Abstract;
using ContactUs.Business1.Admin.ContactUsViews.Concrete;
using ContactUs.DataAccess1.Admin.ContactUsViews;
using ContactUs.DataAccess1.Admin.ContactUsViews.Concrete;
using ContactUs.Entities1.Admin.ContactUsViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsViewController : ControllerBase
    {
        private IContactUsViewService _contactUsViewService;
        public ContactUsViewController()
        {
            _contactUsViewService = new ContactUsViewManager(new ContactUsViewRepository(new ContactUsViewDbContext()));
        }
        [HttpGet("all/{langid}")]
        public List<ContactUsView> GetAllContactUsView(int langId)
        {
            return _contactUsViewService.GetAllContactUsViews(langId).Result;
        }
        [HttpGet("{id}")]
        public ContactUsView GetContactUsViewById(int id)
        {
            return _contactUsViewService.GetContactUsViewById(id).Result;
        }
        [HttpPost]
        public ContactUsView Post([FromBody] ContactUsView contactUsView)
        {
            return _contactUsViewService.AddContactUsView(contactUsView).Result;
        }
        [HttpPut]
        public ContactUsView Put([FromBody] ContactUsView contactUsView)
        {
            return _contactUsViewService.UpdateContactUsView(contactUsView).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _contactUsViewService.DeleteContactUsView(id);
        }


    }
}
