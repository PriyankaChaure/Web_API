using Microsoft.EntityFrameworkCore;

namespace DataAPIContentNegotiationEx.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt)
        { 
        }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Product>().HasData(
                new Product() {ProductID=1,ProductName="Mouse",MfgName="Intex",Price=550},
                new Product() { ProductID = 2, ProductName = "Keyboard", MfgName = "Dell", Price = 850 },
                new Product() { ProductID = 3, ProductName = "Monitor", MfgName = "Benq", Price = 6750 },
                new Product() { ProductID = 4, ProductName = "Pen Drive", MfgName = "HP", Price = 650 },
                new Product() { ProductID = 5, ProductName = "Marker", MfgName = "Renolds", Price = 55 }
                );

        }
        public DbSet<Product> Products { get; set; }

    }
}
