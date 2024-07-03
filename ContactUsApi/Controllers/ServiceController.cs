using ContactUs.Business1.Admin.Services.Abstract;
using ContactUs.Business1.Admin.Services.Concrete;
using ContactUs.DataAccess1.Admin.Services;
using ContactUs.DataAccess1.Admin.Services.Concrete;
using ContactUs.Entities1.Admin.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private IServicesService _servicesService;
        public ServiceController()
        {
            _servicesService = new ServiceManager(new ServiceRepository(new ServiceDbContext()));
        }
        [HttpGet("all/{langId}")]
        public List<Service> Get(int langId)
        {
            return _servicesService.GetAllService(langId).Result;
        }
        [HttpGet("{id}")]
        public Service Gets(int id)
        {
            return _servicesService.GetServiceById(id).Result;
        }
        [HttpPost]
        public Service Post([FromBody] Service service)
        {
            return _servicesService.AddService(service).Result;
        }
        [HttpPut]
        public Service Put([FromBody] Service service)
        {
            return _servicesService.UpdateService(service).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _servicesService.DeleteService(id);
        }
    }
}
