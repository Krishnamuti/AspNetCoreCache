using AspNetCoreCache.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreCache.Data
{
    public class ProductContext: DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options) 
        {}

        public DbSet<Product> Products { get; set; }
    }
}