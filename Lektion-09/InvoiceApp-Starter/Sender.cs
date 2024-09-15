namespace InvoiceApp;

public class Sender
{
  /* PROPERTIES */
  public string Name { get; set; } = "";
  public string Address { get; set; } = "";
  public string PostalCode { get; set; } = "";
  public string City { get; set; } = "";
  public string Phone { get; set; } = "";
  public string Reference { get; set; } = "";
  public string ReferenceEmail { get; set; } = "";

  /* CONSTRUCTORS */
  public Sender()
  {
    LoadSenderInfo();
  }

  /* METHODS */
  public override string ToString()
  {
    return $"Avsändare: {Name} Address: {Address} {PostalCode} {City} Telefon: {Phone} Vår referens: {Reference}";
  }

  /* PRIVATE METHODS */
  private void LoadSenderInfo()
  {
    Name = "Vanhedens järnhandel";
    Address = "Stålgatan 14";
    PostalCode = "888 98";
    City = "Hålan";
    Phone = "073-444222";
    Reference = "Dynamit Harry";
    ReferenceEmail = "harry@gmail.com";
  }
}
