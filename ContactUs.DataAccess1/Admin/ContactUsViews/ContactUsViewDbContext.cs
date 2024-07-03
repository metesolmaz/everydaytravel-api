using ContactUs.Entities1.Admin.ContactUsViews;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactUs.DataAccess1.Admin.ContactUsViews
{
    public class ContactUsViewDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=WIN-?\SQLEXPRESS;Database=?;User Id=?;Password=?;");
        }
        public DbSet<ContactUsView> ContactUsView { get; set; }
    }
}
