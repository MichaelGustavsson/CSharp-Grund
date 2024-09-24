namespace InvoiceApp;

public class Address
{
  /* PROPERTIES */
  public string AddressLine { get; set; } = "";
  public string PostalCode { get; set; } = "";
  public string City { get; set; } = "";

  /* METHODS */
  public override string ToString()
  {
    return $"{AddressLine} Postnummer: {PostalCode} PostOrt: {City}";
  }
}
