﻿using ContactUs.Entities1.Admin.AboutUs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Business1.Admin.AboutUs.Abstract
{
    public interface IAboutUsService
    {
        Task<About> AddAbout(About about);
        Task<About> UpdateAbout(About about);
        Task<List<About>> GetAllAbouts(int langId);
        Task<About> GetAboutById(int id);
        void DeleteAbout(int id);
    }
}
