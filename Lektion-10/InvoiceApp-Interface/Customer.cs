namespace InvoiceApp;

// Parent/Förälder klass
// Realiserar interface ICustomer...
public class Customer : ICustomer, ICustomer2
{
  public string Name { get; set; } = "";
  public Address Address { get; set; } = new Address();
  public string Phone { get; set; } = "";
  public string Reference { get; set; } = "";
  public string Email { get; set; } = "";

  public virtual void Find()
  {
    Name = "Vanhedens järnhandel";
    Address.AddressLine = "Stålgatan 14";
    Address.PostalCode = "888 98";
    Address.City = "Hålan";
    Phone = "073-444222";
    Reference = "Dynamit Harry";
  }
}
