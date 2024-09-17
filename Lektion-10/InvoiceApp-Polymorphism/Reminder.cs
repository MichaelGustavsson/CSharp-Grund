namespace InvoiceApp;

public class Reminder : Invoice
{
  /* PROPERTIES */
  public decimal Interest { get; set; }
  public decimal Charge { get; set; }

  /* CONSTRUCTORS */
  public Reminder(int customerNumber, DateTime dueDate) : base(customerNumber, dueDate)
  {
    Interest = (decimal)0.25;
  }

  /* METHODS */
  public void CalculateReminderTotal()
  {
    Charge = TotalValue * Interest;
    Charge += 50;
    TotalValue += Charge;
  }

  public override string ToString()
  {
    return $"{base.ToString()} Avgift: {Charge}";
  }
}
