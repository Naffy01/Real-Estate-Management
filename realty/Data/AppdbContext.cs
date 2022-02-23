using Microsoft.EntityFrameworkCore;
using realty.Data.Model;

namespace properties.Controllers.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options) : base(options)
        {

        }
        public DbSet<pronat> pron { get; set; }



    }
}
