namespace InvoiceLib;

public class Reminder : Invoice
{
  public decimal Interest { get; set; }
  public decimal Charge { get; set; }
  public Reminder(int customerNumber, int invoiceNumber) : base(customerNumber, invoiceNumber)
  {
    Interest = (decimal)0.25;
  }

  public void CalculateReminderTotal()
  {
    Charge = TotalValue * Interest;
    TotalValue += Charge;
  }

  public override string ToString()
  {
    return $"{base.ToString()} Påminnelseavgift: {Charge}";
  }
}
