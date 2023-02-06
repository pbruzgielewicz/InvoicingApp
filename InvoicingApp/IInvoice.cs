using System.Net.Http.Headers;

namespace InvoicingApp;

public interface IInvoice
{
  int InvoiceNumber { get; set; }
  string CustomerName { get; set; }
  Dictionary<string,Product> Products { get; set; }
  double TotalAmount { get; }
  void AddProduct(Product product);
  void RemoveProduct(string productName);
  public void PrintInvoice(Invoice invoice);
}