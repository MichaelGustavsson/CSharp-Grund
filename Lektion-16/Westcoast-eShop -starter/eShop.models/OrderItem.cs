namespace eShop.models;

public class OrderItem
{
  /* PROPERTIES */
  public decimal Discount { get; set; }
  public decimal LineSum { get; set; }
  public Product? Product { get; set; }
  public int Quantity { get; set; }

  /* METHODS */
  public override string ToString()
  {
    return $"{Discount} {Product} {Quantity} {LineSum}";
  }
}