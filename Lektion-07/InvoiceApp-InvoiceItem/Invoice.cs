using System.Reflection;

namespace InvoiceApp;

public class Invoice
{
  /* PROPERTIES */
  // Base Info...
  public int InvoiceNumber { get; }
  public DateTime InvoiceDate { get; }
  public DateTime DueDate { get; }
  public decimal TotalValue { get; private set; }

  // Sender(Company) Info...
  public string SenderName { get; set; }
  public string SenderAddress { get; set; }
  public string SenderPostalCode { get; set; }
  public string SenderCity { get; set; }
  public string SenderPhone { get; set; }
  public string SenderReference { get; set; }
  public string SenderReferenceEmail { get; set; }

  /* Customer Info... */
  public int CustomerNumber { get; set; }
  public string CustomerName { get; set; }
  public string CustomerAddress { get; set; }
  public string CustomerPostalCode { get; set; }
  public string CustomerCity { get; set; }
  public string CustomerReference { get; set; }
  public int PaymentTerms { get; set; }

  /* Invoice Items... */
  public List<InvoiceItem> InvoiceItems { get; }

  /* CONSTRUCTORS */
  public Invoice()
  {
    SenderName = "";
    SenderAddress = "";
    SenderPostalCode = "";
    SenderCity = "";
    SenderPhone = "";
    SenderReference = "";
    SenderReferenceEmail = "";
    CustomerName = "";
    CustomerAddress = "";
    CustomerPostalCode = "";
    CustomerCity = "";
    CustomerReference = "";

    // Generera fakturanummer...
    InvoiceNumber = new Random().Next(10000, 33000);

    // Sätt betalningsvillkor...
    PaymentTerms = 10;
    // Skapa fakturadatum...
    InvoiceDate = DateTime.Now;
    // Räkna fram förfallodatum...
    DueDate = InvoiceDate.AddDays(PaymentTerms);

    // Initiera(skapa) listan av fakturarader...
    InvoiceItems = new List<InvoiceItem>();
  }

  /* METHODS */
  public void AddInvoiceItem(InvoiceItem invoiceItem)
  {
    InvoiceItems.Add(invoiceItem);
    TotalValue += invoiceItem.LineSum;
  }

  public override string ToString()
  {
    return $"Fakturanummer: {InvoiceNumber} - Fakturadatum: {InvoiceDate} - Förfallodatum: {DueDate} - Kund: {CustomerName} - TotalValue: {TotalValue}";
  }
}
