namespace InvoiceApp;

public class Customer
{
  /* PROPERTIES*/
  public int CustomerNumber { get; set; }
  public string Name { get; set; } = "";
  public string Address { get; set; } = "";
  public string PostalCode { get; set; } = "";
  public string City { get; set; } = "";
  public string Reference { get; set; } = "";
  public int PaymentTerms { get; set; } = 10;

  /* CONSTRUCTORS */
  public Customer() { }

  //  Överlagrad konstruktorn som förväntas ett kundnummer som heltal...
  public Customer(int customerNumber)
  {
    CustomerNumber = customerNumber;
    FindCustomer();
  }

  /* METHODS */
  public override string ToString()
  {
    return $"Kundnamn: {Name} Adress: {Address} {PostalCode} {City} Betalningsvillkor: {PaymentTerms}";
  }

  /* PRIVATE METHODS */
  private void FindCustomer()
  {
    // Information hämtas normalt ifrån någon datalagring av något slag...
    Name = "Bosse Kofot";
    Address = "Rånarvägen 1";
    PostalCode = "666 78";
    City = "Härlanda";
    Reference = "Sickan Carlsson";
    PaymentTerms = 20;
  }
}
