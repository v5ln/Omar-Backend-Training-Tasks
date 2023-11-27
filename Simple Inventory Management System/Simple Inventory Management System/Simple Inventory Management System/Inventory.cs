public class Inventory
{
    private List<Product> products;

    public Inventory()
    {
        products = new List<Product>();
    }

    public void AddProduct(string name, decimal price, int quantity)
    {
        var product = new Product(name, price, quantity);
        products.Add(product);
    }

    public void ViewProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No product, try add some");
            return;
        }
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }

    public void EditProduct(string name, string newName, decimal newPrice, int newQuantity)
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No product, try add some");
            return;
        }
        var product = products.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            product.Name = newName;
            product.Price = newPrice;
            product.Quantity = newQuantity;
            Console.WriteLine("Product Edited.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void DeleteProduct(string name)
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No product, try add some");
            return;
        }
        var product = products.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            products.Remove(product);
            Console.WriteLine("Product Deleted.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void SearchProduct(string name)
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No product, try add some");
            return;
        }
        var product = products.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            Console.WriteLine(product);
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}
