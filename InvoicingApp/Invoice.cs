namespace InvoicingApp;

public class Invoice : IInvoice
{
    public int InvoiceNumber { get; set; }
    public string CustomerName { get; set; }
    public Dictionary<string, Product> Products { get; set; }

    public double TotalAmount
    {
        get
        {
            double total = 0;
            foreach (var product in Products.Values)
            {
                total += product.Price * product.Quantity;
            }
            return total;
        }
    }

    public Invoice(int invoiceNumber, string customerName, Dictionary<string, Product> products)
    {
        InvoiceNumber = invoiceNumber;
        CustomerName = customerName;
        Products = products;
    }
    public void AddProduct(Product product)
    {
        Products[product.ProductName] = product;
    }

    public void RemoveProduct(string productName)
    {
        if (Products.ContainsKey(productName)) Products.Remove(productName);
    }

    public void PrintInvoice(Invoice invoice)
    {
        Console.WriteLine("Invoice Details:");
        Console.WriteLine("Invoice Number: " + invoice.InvoiceNumber);
        Console.WriteLine("Customer Name: " + invoice.CustomerName);
        Console.WriteLine("Products:");
        foreach (var product in invoice.Products.Values)
        {
            Console.WriteLine("Product Name: " + product.ProductName + ", Quantity: " + product.Quantity +
                              ", Price: " + product.Price);
        }

        Console.WriteLine("Total Amount: " + invoice.TotalAmount);
    }
}