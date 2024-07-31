namespace BasicCrudApiWithOData.Models;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    // public char MiddleInitial { get; set; }
    // public string LastName { get; set; }
    // public string Email { get; set; }
    // public string PhoneNumber { get; set; }
    // public string Address { get; set; }
    // public string City { get; set; }
    // public string State { get; set; }
    // public string ZipCode { get; set; }
    // public string Country { get; set; }
    // public int  Age { get; set; }
    public int CreditLimit { get; set; }
    public DateTime CustomerSince { get; set; }
    public CustomerType CustomerType { get; set; }
    //public List<Order> Orders { get; set; }
}