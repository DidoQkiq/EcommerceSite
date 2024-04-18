using ECommerceSite.Infrastructure.Data.Models;
using ECommerceSite.Infrastructure.SeedDataBase;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerceSite.Infrastructure
{
    public class EcommerceSiteDbContext : IdentityDbContext
    {
        public EcommerceSiteDbContext(DbContextOptions<EcommerceSiteDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BrandConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new ColorConfiguration());
            builder.ApplyConfiguration(new SizeConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
