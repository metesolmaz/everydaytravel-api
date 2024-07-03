using ContactUs.Business1.Admin.Languages.Abstract;
using ContactUs.Business1.Admin.Languages.Concrete;
using ContactUs.DataAccess1.Admin.Languages;
using ContactUs.DataAccess1.Admin.Languages.Concrete;
using ContactUs.Entities1.Admin.Languages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EveryDayTravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private ILanguageService _languageService;
        public LanguageController()
        {
            _languageService = new LanguageManager(new LanguageRepository(new LanguageDbContext()));
        }
        [HttpGet()]
        public List<Language> GetAllLanguages()
        {
            return _languageService.GetAllLanguages().Result;
        }
        [HttpGet("{id}")]
        public Language Get(int id)
        {
            return _languageService.GetLanguageById(id).Result;
        }
        [HttpPost]
        public Language Post([FromBody] Language language)
        {
            return _languageService.AddLanguage(language).Result;
        }
        [HttpPut]
        public Language Put([FromBody] Language language)
        {
            return _languageService.UpdateLanguage(language).Result;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _languageService.DeleteLanguage(id);
        }

    }
}
