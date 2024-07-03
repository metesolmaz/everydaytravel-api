using ContactUs.Business1.Admin.ServiceView.Abstract;
using ContactUs.Business1.Admin.ServiceView.Concrete;
using ContactUs.DataAccess1.Admin.ServiceView;
using ContactUs.DataAccess1.Admin.ServiceView.Concrete;
using ContactUs.Entities1.Admin.ServiceView;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceViewController : ControllerBase
    {
        private IServiceViewsService _serviceViewService;
        public ServiceViewController()
        {
            _serviceViewService = new ServiceViewsManager(new ServiceViewsRepository(new ServiceViewsDbContext()));
        }
        [HttpGet("all/{langId}")]
        public List<ServiceViews> Get(int langId)
        {
            return _serviceViewService.GetAllServiceView(langId).Result;
        }
        [HttpGet("{id}")]
        public ServiceViews Gets(int id)
        {
            return _serviceViewService.GetServiceViewById(id).Result;
        }
        [HttpPost]
        public ServiceViews Post([FromBody] ServiceViews serviceViews)
        {
            return _serviceViewService.AddServiceView(serviceViews).Result;
        }
        [HttpPut]
        public ServiceViews Put([FromBody] ServiceViews serviceViews)
        {
            return _serviceViewService.UpdateServiceView(serviceViews).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _serviceViewService.DeleteServiceView(id);
        }
    }
}
