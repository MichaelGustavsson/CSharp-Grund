using eShop.models;
using Microsoft.AspNetCore.Mvc;

namespace eShop.client.Controllers;
public class CartController : Controller
{
  List<Cart> _cartContents = [];
  private readonly string _wwwroot;
  public CartController(IWebHostEnvironment environment)
  {
    _wwwroot = environment.WebRootPath;
    string path = string.Concat(_wwwroot, "/data/carts.json");
    _cartContents = Storage<Cart>.ReadJson(path);
  }
  public ActionResult Index()
  {
    return View(_cartContents);
  }
  public ActionResult Add(int id)
  {
    // TODO: ADD LOGIC TO SAVE PRODUCT TO JSON...
    Product product = FindProduct(id);
    if (SaveToDB(product))
    {
      return RedirectToAction("Index");
    }
    else
    {
      // Skickat oss till en felsida...
      return RedirectToAction("Index");
    }
  }

  public ActionResult CheckOut()
  {
    // Vi måste skapa ett Produkt objekt för varje objekt
    // i kundkorgen...
    List<OrderItem> orderItems = [];
    foreach (var item in _cartContents)
    {
      OrderItem orderItem = new();
      Product product = new Product()
      {
        ProductId = item.ProductId,
        ItemNumber = item.ItemNumber,
        Name = item.Name,
        Price = item.Price
      };

      orderItem.Product = product;
      orderItem.Discount = 0.00M;
      orderItem.Quantity = 1;
      orderItem.LineSum = product.Price * orderItem.Quantity;
      orderItems.Add(orderItem);
    }
    // Skapa en ny order...
    SalesOrder order = new SalesOrder();
    order.OrderItems = orderItems;
    order.Customer = new Customer() { FirstName = "Michael", LastName = "Gustavsson" };
    order.OrderDate = DateTime.Now;
    order.OrderId = 1;

    // Skriv beställningen till order.json
    List<SalesOrder> orders = [];
    orders.Add(order);
    string path = string.Concat(_wwwroot, "/data/order.json");
    Storage<SalesOrder>.WriteJson(path, orders);

    // Töm kundkorgen
    path = string.Concat(_wwwroot, "/data/carts.json");
    _cartContents = [];
    Storage<Cart>.WriteJson(path, _cartContents);


    return View("Confirmation");
  }

  private Product FindProduct(int id)
  {
    string path = string.Concat(_wwwroot, "/data/products.json");
    List<Product> products = Storage<Product>.ReadJson(path);
    Product product = products.SingleOrDefault(c => c.ProductId == id)!;
    return product;
  }

  private bool SaveToDB(Product product)
  {
    // Skapar ett nytt objekt av typen Cart...
    // och flyttar produkt objektets värden över till cart objektet
    Cart cart = new()
    {
      ProductId = product.ProductId,
      ItemNumber = product.ItemNumber,
      Name = product.Name,
      Price = product.Price
    };

    // Lägg cart objektet i listan _cartContents...
    _cartContents.Add(cart);
    // Skapa sökvägen till carts.json
    string path = string.Concat(_wwwroot, "/data/carts.json");
    // Skriv ner skiten till filen...
    Storage<Cart>.WriteJson(path, _cartContents);

    return true;
  }
}