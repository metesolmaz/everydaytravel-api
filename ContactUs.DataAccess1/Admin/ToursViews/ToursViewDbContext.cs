﻿using ContactUs.Entities1.Admin.ToursViews;
using Microsoft.EntityFrameworkCore;

namespace ContactUs.DataAccess1.Admin.ToursViews
{
    public class ToursViewDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=WIN-?\SQLEXPRESS;Database=?;User Id=?;Password=?;");
        }
        public DbSet<ToursView> ToursView { get; set; }
    }
}