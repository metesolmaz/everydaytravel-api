using ContactUs.Entities1.Admin.ServiceView;
using Microsoft.EntityFrameworkCore;

namespace ContactUs.DataAccess1.Admin.ServiceView
{
    public class ServiceViewsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=WIN-?\SQLEXPRESS;Database=?;User Id=?;Password=?;");
        }
        public DbSet<ServiceViews> ServiceViews { get; set; }
    }
}
