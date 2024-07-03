using ContactUs.Entities1.Admin.Services;
using Microsoft.EntityFrameworkCore;

namespace ContactUs.DataAccess1.Admin.Services
{
    public class ServiceDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=WIN-?\SQLEXPRESS;Database=?;User Id=?;Password=?;");
        }
        public DbSet<Service> Service { get; set; }
    }
}
