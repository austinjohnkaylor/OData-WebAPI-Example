namespace BasicCrudApiWithOData.Models;

public class ProductAttribute
{
    public Guid Id { get; set; }
    public Product Product { get; set; }
    public Attribute Attribute { get; set; }
}