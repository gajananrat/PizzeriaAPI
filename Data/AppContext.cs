using Microsoft.EntityFrameworkCore;
using PizzeriaAPI.Models;

namespace PizzeriaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Pizzas> Pizzas { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<PizzaIngredients> PizzaIngredients { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
