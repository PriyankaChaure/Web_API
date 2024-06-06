using Microsoft.EntityFrameworkCore;

namespace CURDUsingAPIEx.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt)
        { 
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Product>().HasData(new Product() {ProductID=1,ProductName="Mouse",MfgName="Intex",Price=410});
            mb.Entity<Product>().HasData(new Product() { ProductID = 2, ProductName = "Keyboard", MfgName = "Logitech", Price = 410 });
            mb.Entity<Product>().HasData(new Product() { ProductID = 3, ProductName = "Monitor", MfgName = "LG", Price = 4100 });
            mb.Entity<Product>().HasData(new Product() { ProductID = 4, ProductName = "Marker", MfgName = "Renolds", Price = 50 });

            mb.Entity<User>().HasData(new User() { UserID = 1, FirstName = "Sunil", LastName = "Patil", EmailID = "sunil@gmail.com", Password = "abcd" });

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
    }
}
