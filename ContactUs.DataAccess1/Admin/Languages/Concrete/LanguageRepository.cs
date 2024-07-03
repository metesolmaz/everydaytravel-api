using ContactUs.DataAccess1.Admin.Languages.Abstract;
using ContactUs.Entities1.Admin.Languages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.Languages.Concrete
{
    public class LanguageRepository : ILanguageRepository
    {
        private LanguageDbContext _language;
        public LanguageRepository(LanguageDbContext language)
        {
            _language = language;
        }

        public async Task<Language> AddLanguage(Language language)
        {
            _language.Language.Add(language);
            await _language.SaveChangesAsync();
            return language;
        }

        public void DeleteLanguage(int id)
        {
            _language.Language.Remove(new Language { id = id });
            _language.SaveChanges();
        }

        public async Task<List<Language>> GetAllLanguages()
        {
            return await _language.Language.ToListAsync();
        }

        public async Task<Language> GetLanguageById(int id)
        {
            if (id > 0)
            {
                return await _language.Language.FirstOrDefaultAsync(x => x.id == id);
            }
            throw new Exception("Id can not be less than 1");
        }

        public async Task<Language> UpdateLanguage(Language language)
        {
            _language.Language.Update(language);
            await _language.SaveChangesAsync();
            return language;
        }
    }
}
