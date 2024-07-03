using ContactUs.Entities1.Admin.CallOuts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.CallOuts.Abstract
{
    public interface ICallOutService
    {
        Task<CallOut> AddCallOut(CallOut callout);
        Task<CallOut> UpdateCallOut(CallOut callout);
        Task<List<CallOut>> GetAllCallOuts(int langId);
        Task<CallOut> GetCallOutById(int id);
        void DeleteCallOut(int id);
    }
}
