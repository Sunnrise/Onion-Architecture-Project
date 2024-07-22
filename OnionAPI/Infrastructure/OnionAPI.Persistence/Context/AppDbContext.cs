

using Microsoft.EntityFrameworkCore;
using OnionAPI.Domain.Entities;
using System.Reflection;

namespace OnionAPI.Persistence.Context
{
    public class AppDbContext: DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<ProductCategory>ProductCategories { get; set; }
        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
