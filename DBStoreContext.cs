using Microsoft.EntityFrameworkCore;

namespace FullstackWebshopBackend
{
    public class DBStoreContext : DbContext
    {
        public DbSet<ProductData> Products { get; set; }
        public DBStoreContext(DbContextOptions<DBStoreContext> options) : base(options)
        {
        }
    }
}
