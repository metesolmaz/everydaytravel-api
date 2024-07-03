using ContactUs.Entities1.Admin.Languages;
using Microsoft.EntityFrameworkCore;

namespace ContactUs.DataAccess1.Admin.Languages
{
    public class LanguageDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=WIN-?\SQLEXPRESS;Database=?;User Id=?;Password=?;");
        }
        public DbSet<Language> Language { get; set; }
    }
}
