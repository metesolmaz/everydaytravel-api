using ContactUs.Business1.Admin.CallOuts.Abstract;
using ContactUs.DataAccess1.Admin.CallOuts.Abstract;
using ContactUs.Entities1.Admin.CallOuts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.CallOuts.Concrete
{
    public class CallOutManager : ICallOutService
    {
        private ICallOutRepository _callOutRepository;

        public CallOutManager(ICallOutRepository callOutRepository)
        {
            _callOutRepository = callOutRepository;
        }
        public Task<CallOut> AddCallOut(CallOut callout)
        {
            return _callOutRepository.AddCallOut(callout);
        }

        public void DeleteCallOut(int id)
        {
            _callOutRepository.DeleteCallOut(id);
        }

        public Task<List<CallOut>> GetAllCallOuts(int langId)
        {
            return _callOutRepository.GetAllCallOuts(langId);
        }

        public Task<CallOut> GetCallOutById(int id)
        {
            return _callOutRepository.GetCallOutById(id);
        }

        public Task<CallOut> UpdateCallOut(CallOut callout)
        {
            return _callOutRepository.UpdateCallOut(callout);
        }
    }
}
