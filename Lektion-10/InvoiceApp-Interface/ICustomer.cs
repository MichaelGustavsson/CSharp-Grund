namespace InvoiceApp;

public interface ICustomer
{
  /* PROPERTIES */
  public string Name { get; set; }
  public Address Address { get; set; }
  public string Phone { get; set; }
  public string Reference { get; set; }

  /* METHODS */
  public void Find();
}
