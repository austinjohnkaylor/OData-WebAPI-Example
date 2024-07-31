using BasicCrudApiWithOData.Models;

namespace BasicCrudApiWithOData.EntityFrameworkCore;

internal static class DatabaseHelper
{
    public static void SeedDb(BasicCrudDbContext db)
    {
        if (!db.Customers.Any())
        {
            db.Add(new Customer
            {
                Id = 1,
                FirstName = "Sue",
                CustomerType = CustomerType.Retail,
                CreditLimit = 3700,
                CustomerSince = new DateTime(2022, 7, 4)
            });

            db.Add(new Customer
            {
                Id = 2,
                FirstName = "Joe",
                CustomerType = CustomerType.Wholesale,
                CreditLimit = 5100,
                CustomerSince = new DateTime(2022, 12, 12)
            });

            db.SaveChanges();
        }
    }
}