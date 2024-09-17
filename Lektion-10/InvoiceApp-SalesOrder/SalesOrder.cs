namespace InvoiceApp;

public class SalesOrder
{
  /* PROPERTIES */
  public int PurchaseNumber { get; set; }
  public DateTime PurchaseDate { get; set; }
  public decimal TotalValue { get; set; }
  public Customer Customer { get; set; } = new Customer();
  public List<ProductItem> ProductItems { get; set; } = new List<ProductItem>();

  /* METHODS */
  public void AddProductItem(ProductItem productItem)
  {
    ProductItems.Add(productItem);
    TotalValue += productItem.LineSum;
  }
}
