using ContactUs.Business1.Admin.Languages.Abstract;
using ContactUs.DataAccess1.Admin.Languages.Abstract;
using ContactUs.Entities1.Admin.Languages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.Languages.Concrete
{
    public class LanguageManager : ILanguageService
    {
        private readonly ILanguageRepository _languageRepository;
        public LanguageManager(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }
        public  Task<Language> AddLanguage(Language language)
        {
            return _languageRepository.AddLanguage(language);
        }

        public void DeleteLanguage(int id)
        {
            _languageRepository.DeleteLanguage(id);
        }

        public  Task<List<Language>> GetAllLanguages()
        {
            return _languageRepository.GetAllLanguages();
        }

        public  Task<Language> GetLanguageById(int id)
        {
            return _languageRepository.GetLanguageById(id);
        }

        public Task<Language> UpdateLanguage(Language language)
        {
            return _languageRepository.UpdateLanguage(language);
        }
    }
    
}
