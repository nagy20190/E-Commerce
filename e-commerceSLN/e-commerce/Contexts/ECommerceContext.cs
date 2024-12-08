using e_commerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Contexts
{
    public class ECommerceContext: DbContext
    {
        public ECommerceContext() : base()
        {
        }
        public ECommerceContext(DbContextOptions<ECommerceContext> options) :base(options) 
        {
        }
        // Not Recomnded !
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server =.;Database =Team_E_Commerce; integrated security = true; Encrypt=False;Trust Server Certificate=True");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(r => new { r.ProductId, r.CartId});

            modelBuilder.Entity<OrderItem>()
                .HasKey(s => new { s.ProductId, s.OrderId});
        }

        public DbSet<CartItem> cartItems { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<ShoppingCart> shoppingCarts { get; set; }

    }
}
