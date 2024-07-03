using ContactUs.Entities1.Admin.CallOuts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.CallOuts.Abstract
{
    public interface ICallOutRepository
    {
        Task<CallOut> AddCallOut(CallOut callout);
        Task<CallOut> UpdateCallOut(CallOut callout);
        Task<List<CallOut>> GetAllCallOuts(int langId);
        Task<CallOut> GetCallOutById(int id);
        void DeleteCallOut(int id);
    }
}
