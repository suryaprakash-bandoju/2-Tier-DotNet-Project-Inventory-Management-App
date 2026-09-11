using InventoryManagement.Models;

namespace InventoryManagement.Services;

public class ProductService
{
    private readonly List<Product> products = new()
    {
        new Product
        {
            Id = 1,
            Name = "Laptop",
            Category = "Electronics",
            Price = 65000,
            Quantity = 12
        },
        new Product
        {
            Id = 2,
            Name = "Wireless Mouse",
            Category = "Accessories",
            Price = 1200,
            Quantity = 35
        },
        new Product
        {
            Id = 3,
            Name = "Keyboard",
            Category = "Accessories",
            Price = 2500,
            Quantity = 20
        }
    };

    public List<Product> GetAll()
    {
        return products;
    }

    public void Add(Product product)
    {
        product.Id = products.Count == 0 ? 1 : products.Max(p => p.Id) + 1;
        products.Add(product);
    }

    public void Delete(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);

        if (product != null)
        {
            products.Remove(product);
        }
    }
}