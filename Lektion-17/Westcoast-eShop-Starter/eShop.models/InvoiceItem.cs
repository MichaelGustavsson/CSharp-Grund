namespace eShop.models;

public class InvoiceItem
{
  /* PROPERTIES */
  public int Quantity { get; set; }
  public decimal LineSum { get; set; }
  public Product Product { get; set; }

  /* CONSTRUCTOR */
  public InvoiceItem(int quantity, Product product)
  {
    Product = product;
    Quantity = quantity;
    LineSum = Product.Price * Quantity;
  }

  /* METHODS */
  public override string ToString()
  {
    return $"{Product} Antal: {Quantity} Radvärde: {LineSum}";
  }
}