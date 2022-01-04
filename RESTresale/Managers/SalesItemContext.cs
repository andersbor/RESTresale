using Microsoft.EntityFrameworkCore;
using RESTresale.Models;

namespace RESTresale.Managers
{
    public class SalesItemContext : DbContext
    {
        public SalesItemContext
            (DbContextOptions<SalesItemContext> options) : base(options) { }

        public DbSet<ResaleItem> ResaleItems { get; set; }
    }
}
