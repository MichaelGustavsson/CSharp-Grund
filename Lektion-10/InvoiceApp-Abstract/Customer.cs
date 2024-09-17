namespace InvoiceApp;

// Parent/Förälder klass
public abstract class Customer
{
  public abstract string Name { get; set; }
  public abstract Address Address { get; set; }
  public abstract string Phone { get; set; }
  public abstract string Reference { get; set; }

  public abstract void Find();
}
