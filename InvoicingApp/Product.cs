namespace InvoicingApp;

public class Product
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Product(string name, int quantity, double price)
    {
        ProductName = name;
        Quantity = quantity;
        Price = price;
    }
    

}