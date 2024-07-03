using ContactUs.Business1.Admin.CallOuts.Abstract;
using ContactUs.Business1.Admin.CallOuts.Concrete;
using ContactUs.DataAccess1.Admin.CallOuts;
using ContactUs.DataAccess1.Admin.CallOuts.Concrete;
using ContactUs.Entities1.Admin.CallOuts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallOutController : ControllerBase
    {
        private ICallOutService _calloutService;
        public CallOutController()
        {
            _calloutService = new CallOutManager(new CallOutRepository(new CallOutDbContext()));
        }
        [HttpGet("all/{langid}")]
        public List<CallOut> GetAllCallOut(int langId)
        {
            return _calloutService.GetAllCallOuts(langId).Result;
        }
        [HttpGet("{id}")]
        public CallOut Get(int id)
        {
            return _calloutService.GetCallOutById(id).Result;
        }
        [HttpPost]
        public CallOut Post([FromBody] CallOut callout)
        {
            return _calloutService.AddCallOut(callout).Result;
        }
        [HttpPut]
        public CallOut Put([FromBody] CallOut callout)
        {
            return _calloutService.UpdateCallOut(callout).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _calloutService.DeleteCallOut(id);
        }
    }
}
