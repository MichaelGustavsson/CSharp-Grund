using eShop.models;
using Microsoft.AspNetCore.Mvc;

namespace eShop.client.Controllers;
public class ProductsController : Controller
{
  private readonly List<Product> _products;
  public ProductsController(IWebHostEnvironment environment)
  {
    string wwwroot = environment.WebRootPath;
    string path = string.Concat(wwwroot, "/data/products.json");
    _products = GetProducts(path);
  }
  public ActionResult Index()
  {
    return View(_products);
  }

  private List<Product> GetProducts(string path)
  {
    return Storage<Product>.ReadJson(path);
  }
}