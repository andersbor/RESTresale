using Microsoft.EntityFrameworkCore;

namespace RESTresale.Managers
{
    public class SalesItemContext : DbContext
    {
        public SalesItemContext
            (DbContextOptions<SalesItemContext> options) : base(options) { }

        public DbSet<SalesItemContext> SalesItems { get; set; }
    }
}
