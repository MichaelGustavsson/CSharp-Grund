namespace eShop.models;

public class Product
{
  /* PROPERTIES */
  public int ProductId { get; set; }
  public string? ItemNumber { get; set; }
  public string? Name { get; set; }
  public decimal Price { get; set; }

  /* METHODS */
  public override string ToString()
  {
    return $"{ProductId} {Name} {Price}";
  }
}