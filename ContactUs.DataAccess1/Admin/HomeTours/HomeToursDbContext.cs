using Microsoft.EntityFrameworkCore;

namespace ContactUs.DataAccess1.Admin.HomeTours
{
    public class HomeToursDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=WIN-?\SQLEXPRESS;Database=?;User Id=?;Password=?;");
        }
        public DbSet<Entities1.Admin.HomeTours.HomeTours> HomeTours { get; set; }
    }
}
