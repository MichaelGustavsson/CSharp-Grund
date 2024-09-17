namespace InvoiceApp;

public class Sender : Customer
{
  /* PROPERTIES */
  public string ReferenceEmail { get; set; } = "";
  public override string Name { get; set; } = "";
  public override Address Address { get; set; } = new Address();
  public override string Phone { get; set; } = "";
  public override string Reference { get; set; } = "";

  /* CONSTRUCTORS */
  public Sender()
  {
    Find();
  }

  /* METHODS */

  public override void Find()
  {
    Name = "Vanhedens järnhandel";
    Address.AddressLine = "Stålgatan 14";
    Address.PostalCode = "888 98";
    Address.City = "Hålan";
    Phone = "073-444222";
    Reference = "Dynamit Harry";
  }
  public override string ToString()
  {
    return $"Avsändare: {Name} Address: {Address} Telefon: {Phone} Vår referens: {Reference}";
  }
}
