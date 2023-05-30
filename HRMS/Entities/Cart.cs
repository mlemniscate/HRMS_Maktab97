namespace HRMS.Entities;

public class Cart
{
    public Cart(List<string> products)
    {
        Id = Guid.NewGuid();
        SetProducts(products);
    }

    private void SetProducts(List<string> products)
    {
        if (products.Count == 0)
            throw new Exception("Product Count cannot be zero.");
        Products = products;
    }

    public Guid Id { get; set; }
    public List<string> Products { get; set; }
}