using Microsoft.EntityFrameworkCore;
using Task2MVC.Models;
namespace Task2MVC.context
{
    public class conrctioncs:DbContext
    {
        public conrctioncs(DbContextOptions<conrctioncs> options) : base(options)
        {
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
   
