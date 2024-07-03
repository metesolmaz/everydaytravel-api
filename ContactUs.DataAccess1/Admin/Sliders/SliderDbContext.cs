using ContactUs.Entities1.Admin.Sliders;
using Microsoft.EntityFrameworkCore;

namespace ContactUs.DataAccess1.Admin.Sliders
{
    public class SliderDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=WIN-?\SQLEXPRESS;Database=?;User Id=?;Password=?;");
        }
        public DbSet<Slider> Slider { get; set; }
    }
}
