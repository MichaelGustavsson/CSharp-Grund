namespace InvoiceApp;

public class Invoice
{
  /* PROPERTIES */
  // Base Info...
  public int InvoiceNumber { get; }
  public DateTime InvoiceDate { get; }
  public DateTime DueDate { get; }
  public decimal TotalValue { get; protected set; }
  // Composition
  // Invoice har en referens/relation till Company klassen
  public Company Customer { get; set; }
  // Invoice har en referens/relation till Sender klassen
  public Sender Sender { get; set; }


  /* Invoice Items/Faktura rader... */
  // Aggregation...
  public List<InvoiceItem> InvoiceItems { get; }

  /* CONSTRUCTORS */
  // Vi ska ALDRIG kunna skapa en faktura utan kundnummer
  public Invoice(int customerNumber)
  {
    Customer = new Company(customerNumber);
    Sender = new Sender();
    // Generera fakturanummer...
    InvoiceNumber = new Random().Next(10000, 33000);

    // Skapa fakturadatum...
    InvoiceDate = DateTime.Now;
    // Räkna fram förfallodatum...
    DueDate = InvoiceDate.AddDays(Customer.PaymentTerms);

    // Initiera(skapa) listan av fakturarader...
    InvoiceItems = new List<InvoiceItem>();
  }

  public Invoice(int customerNumber, DateTime dueDate) : this(customerNumber)
  {
    DueDate = dueDate;
  }

  /* METHODS */
  public void AddInvoiceItem(InvoiceItem invoiceItem)
  {
    InvoiceItems.Add(invoiceItem);
    TotalValue += invoiceItem.LineSum;
  }

  public override string ToString()
  {
    return $"{Sender} Fakturanummer: {InvoiceNumber} - Fakturadatum: {InvoiceDate} - Förfallodatum: {DueDate} - {Customer} - TotalValue: {TotalValue}";
  }
}
