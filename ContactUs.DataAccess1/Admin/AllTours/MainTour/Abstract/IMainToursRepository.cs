﻿using ContactUs.Entities1.Admin.AllTours;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.DataAccess1.Admin.AllTours.MainTour.Abstract
{
    public  interface IMainToursRepository
    {
        Task<List<MainTours>> GetAllMainTours(int langId);
        Task<MainTours> GetMainToursById(int id);
        Task<MainTours> AddMainTours(MainTours tours);
        Task<MainTours> UpdateMainTours(MainTours tours);
        void DeleteMainTours(int id);
    }
}
