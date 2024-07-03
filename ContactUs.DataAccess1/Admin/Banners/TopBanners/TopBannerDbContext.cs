using ContactUs.Entities1.Admin.Banners;
using Microsoft.EntityFrameworkCore;

namespace ContactUs.DataAccess1.Admin.Banners.TopBanners
{
    public class TopBannerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=WIN-?\SQLEXPRESS;Database=?;User Id=?;Password=?;");
        }   
        public DbSet<TopBanner> TopBanner { get; set; }
    }
}
