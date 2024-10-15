namespace eShop.models;

public class Invoice
{
  /* PROPERTIES */
  public int InvoiceNumber { get; set; }
  public DateTime InvoiceDate { get; set; }
  public DateTime DueDate { get; set; }
  public decimal TotalValue { get; set; }
  public Customer Customer { get; set; }
  public List<InvoiceItem> InvoiceItems { get; set; }

  /* CONSTRUCTORS */
  public Invoice(Customer customer)
  {
    Customer = customer;
    InvoiceDate = DateTime.Now;
    DueDate = InvoiceDate.AddDays(30);
    InvoiceItems = [];
  }

  /* METODS */
  public void AddInvoiceItem(InvoiceItem item)
  {
    InvoiceItems.Add(item);
    TotalValue += item.LineSum;
  }

  public override string ToString()
  {
    return $"Fakturanummer: {InvoiceNumber} {InvoiceDate} {DueDate} {TotalValue}";
  }
}