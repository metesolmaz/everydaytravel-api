using ContactUs.DataAccess1.Admin.CallOuts.Abstract;
using ContactUs.Entities1.Admin.CallOuts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.CallOuts.Concrete
{
    public class CallOutRepository : ICallOutRepository
    {
        private readonly CallOutDbContext _callOut;
        public CallOutRepository(CallOutDbContext callOut)
        {
            _callOut = callOut;
        }
        public async Task<CallOut> AddCallOut(CallOut callout)
        {
            await _callOut.CallOut.AddAsync(callout);
            await _callOut.SaveChangesAsync();
            return callout;
        }

        public void DeleteCallOut(int id)
        {

            _callOut.CallOut.Remove(new CallOut { id = id });
            _callOut.SaveChanges();
        }

        public async Task<List<CallOut>> GetAllCallOuts(int langId)
        {
            return await _callOut.CallOut.Where(x => x.LanguageId == langId).ToListAsync();
        }

        public async Task<CallOut> GetCallOutById(int id)
        {
            return await _callOut.CallOut.FindAsync(id);
        }

        public async Task<CallOut> UpdateCallOut(CallOut callout)
        {
            _callOut.CallOut.Update(callout);
            await _callOut.SaveChangesAsync();
            return callout;
        }
    }


}
