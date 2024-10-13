namespace eShop.models;

// Klassen SalesOrder
// Ska ha egenskaperna OrderDate,OrderId
public class SalesOrder
{
  /* PROPERTIES */
  public int OrderId { get; set; }
  public Customer? Customer { get; set; }
  public DateTime OrderDate { get; set; }
  public List<OrderItem>? OrderItems { get; set; }

  /* METHODS */
  public override string ToString()
  {
    return $"{OrderId} {OrderDate.ToString("yyyy-MM-dd")} {Customer}";
  }
}