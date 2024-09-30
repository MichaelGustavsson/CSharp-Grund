namespace InvoiceLib;

public class Company : Customer
{
  /* PROPERTIES*/
  public int CustomerNumber { get; set; }
  public Address InvoiceAddress { get; set; } = new Address();
  public int PaymentTerms { get; set; } = 10;

  /* CONSTRUCTORS */
  public Company() { }

  //  Överlagrad konstruktorn som förväntas ta ett kundnummer som heltal...
  public Company(int customerNumber)
  {
    CustomerNumber = customerNumber;
    Find();
  }

  /* METHODS */
  public override string ToString()
  {
    return $"Kundnamn: {Name} Adress: {Address} Faktura adress: {InvoiceAddress} Betalningsvillkor: {PaymentTerms}";
  }


  public override void Find()
  {

    // Information hämtas normalt ifrån någon datalagring av något slag...
    Name = "Bosse Kofot";
    Address.AddressLine = "Rånarvägen 1";
    Address.PostalCode = "666 78";
    Address.City = "Härlanda";
    Reference = "Sickan Carlsson";
    PaymentTerms = 20;

    // Faktura adress...
    InvoiceAddress.AddressLine = "Fakturavägen 12";
    InvoiceAddress.PostalCode = "123 45";
    InvoiceAddress.City = "Storstaden";
  }
}
