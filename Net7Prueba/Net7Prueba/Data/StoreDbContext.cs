using Net7Prueba.Models;
using Microsoft.EntityFrameworkCore;

namespace Net7Prueba.Data
{
    public class StoreDbContext : DbContext
    {
        #region Constructor
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }

        #endregion

        public DbSet<ProductEntity> Products { get; set; }
    }
}
