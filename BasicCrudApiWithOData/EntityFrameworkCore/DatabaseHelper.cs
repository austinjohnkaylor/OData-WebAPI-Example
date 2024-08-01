using BasicCrudApiWithOData.Models;

namespace BasicCrudApiWithOData.EntityFrameworkCore;

internal static class DatabaseHelper
{
    public static void SeedDb(BasicCrudDbContext db)
    {
        if (db.Customers.Any()) return;
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
        
        db.Add(new Customer
        {
            Id = 3,
            FirstName = "Butch",
            CustomerType = CustomerType.Wholesale,
            CreditLimit = 2000,
            CustomerSince = new DateTime(2023, 4, 5)
        });
        
        db.Add(new Customer
        {
            Id = 4,
            FirstName = "Cathy",
            CustomerType = CustomerType.Wholesale,
            CreditLimit = 10000,
            CustomerSince = new DateTime(2022, 1, 15)
        });
        
        db.Add(new Customer
        {
            Id = 5,
            FirstName = "Ace",
            CustomerType = CustomerType.Wholesale,
            CreditLimit = 20000,
            CustomerSince = new DateTime(2020, 01, 01)
        });

        db.SaveChanges();
    }
}