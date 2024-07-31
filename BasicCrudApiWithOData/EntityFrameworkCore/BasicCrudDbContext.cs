using BasicCrudApiWithOData.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicCrudApiWithOData.EntityFrameworkCore;

public class BasicCrudDbContext : DbContext
{
    public BasicCrudDbContext(DbContextOptions<BasicCrudDbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
}