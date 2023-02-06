namespace InvoicingApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter invoice number: ");
                int invoiceNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter customer name: ");
                string customerName = Console.ReadLine();

                Dictionary<string, Product> products = new Dictionary<string, Product>();
                while (true)
                {
                    Console.WriteLine("Enter product name (enter 'done' to finish): ");
                    string productName = Console.ReadLine();
                    if (productName.ToLower() == "done") break;
                    Console.WriteLine("Enter quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter price: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    products[productName] = new Product(productName, quantity, price);
                }

                Invoice invoice = new Invoice(invoiceNumber, customerName, products);

                invoice.PrintInvoice(invoice);
                UpdateProductQuantity(ref products, "raspberyPi", 20);
                invoice.PrintInvoice(invoice);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("The program ends here");
            }

        }
        public static void UpdateProductQuantity(ref Dictionary<string, Product> products, string productName, int newQuantity)
        {
            if (products.ContainsKey(productName))
            {
                products[productName].Quantity = newQuantity;
            }
        }
    }
}     
        