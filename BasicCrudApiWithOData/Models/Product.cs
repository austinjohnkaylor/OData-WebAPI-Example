namespace BasicCrudApiWithOData.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<ProductAttribute> ProductAttributes { get; set; }
}