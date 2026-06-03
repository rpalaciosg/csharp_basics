partial class Program
{
  static void InventoryManagement()
  {
    Inventory inventory = new();
    Product laptop = new("Laptop", 999.99m, 10);
    Product smartphone = new("Smartphone", 499.99m, 20);
    inventory.AddProduct(laptop);
    inventory.AddProduct(smartphone);
    inventory.ShowInventory();
    laptop.Sell(2);
    smartphone.Sell(5);
    inventory.ShowInventory();

  }
}

class Product
{
  public string? Name {get; set;}
  public decimal Price {get; set;}
  public int? Stock {get; set;}
  
  public Product(string name, decimal price, int stock)
  {
    Name = name;
    Price = price;
    Stock = stock;
  }
  
  public void ShowInfo()
  {
    WriteLine($"Product: {Name}, Price: {Price:C}, Stock: {Stock}");
  }
  
  public bool Sell(int quantity)
  {
    if(Stock.HasValue && Stock.Value >= quantity)
    {
      Stock -= quantity;
      WriteLine($"Sold {quantity} of {Name}. Remaining stock: {Stock}");
      return true;
    }
    WriteLine($"Insufficient stock for {Name}. Available stock: {Stock}");
    return false;
  }
}

class Inventory
{
  private List<Product> products = new List<Product>();

  public void AddProduct(Product product)
  {
    products.Add(product);
    WriteLine($"Added {product.Name} to inventory.");
  }
  
  public void ShowInventory()
  {
    WriteLine("Current Inventory:");
    foreach(var product in products)
    {
      product.ShowInfo();
    }
  }
}

