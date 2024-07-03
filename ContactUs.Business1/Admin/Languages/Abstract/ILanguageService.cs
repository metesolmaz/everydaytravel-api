using ContactUs.Entities1.Admin.Languages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Languages.Abstract
{
    public  interface ILanguageService
    {
        Task<List<Language>> GetAllLanguages();
        Task<Language> GetLanguageById(int id);
        Task<Language> AddLanguage(Language language);
        Task<Language> UpdateLanguage(Language language);
        void DeleteLanguage(int id);


    }
}
