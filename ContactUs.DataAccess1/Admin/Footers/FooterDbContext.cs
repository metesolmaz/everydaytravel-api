using ContactUs.Entities1.Admin.Footers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactUs.DataAccess1.Admin.Footers
{
    public class FooterDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=WIN-?\SQLEXPRESS;Database=?;User Id=?;Password=?;");
        }
        public DbSet<Footer> Footer { get; set; }
    }
}
