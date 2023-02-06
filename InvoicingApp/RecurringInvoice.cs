namespace InvoicingApp;

public class RecurringInvoice : Invoice
{
    public int RecurrenceInterval { set; get; }
    public RecurringInvoice(int invoiceNumber, string customerName, Dictionary<string, Product> products, int recurrenceInterval) : base(invoiceNumber, customerName, products)
    {
        RecurrenceInterval = recurrenceInterval;
    }

    public void GenerateInvoices(Queue<Invoice> invoiceQueue)
    {
        for (int i = 1; i <= RecurrenceInterval; i++)
        {
            invoiceQueue.Enqueue(new Invoice(InvoiceNumber + i, CustomerName, Products));
        }
    }
}