using Microsoft.EntityFrameworkCore;
using Shared.Entities;

namespace Shared.EntityFramework;

public class DummyDbContext(DbContextOptions<DummyDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
}
