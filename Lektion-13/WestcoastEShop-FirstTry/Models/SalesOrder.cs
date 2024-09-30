namespace Westcoast_EShop.Models;

// Klassen SalesOrder
// Ska ha egenskaperna OrderDate,OrderId
public class SalesOrder
{
  public int OrderId { get; set; }
  public DateTime OrderDate { get; set; }
  public Customer? Customer { get; set; }
}