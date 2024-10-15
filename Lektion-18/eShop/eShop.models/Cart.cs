namespace eShop.models;

public class Cart : IItem
{
  public int ProductId { get; set; }
  public string? ItemNumber { get; set; }
  public string? Name { get; set; }
  public decimal Price { get; set; }
}