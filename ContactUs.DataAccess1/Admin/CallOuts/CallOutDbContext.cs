﻿using ContactUs.Entities1.Admin.CallOuts;
using Microsoft.EntityFrameworkCore;

namespace ContactUs.DataAccess1.Admin.CallOuts
{
    public class CallOutDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=WIN-?\SQLEXPRESS;Database=?;User Id=?;Password=?;");
        }
        public DbSet<CallOut> CallOut { get; set; }
    }
}