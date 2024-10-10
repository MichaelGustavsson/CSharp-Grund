using eShop.models;
using Microsoft.AspNetCore.Mvc;

namespace eShop.web.Controllers;

public class ProductsController : Controller
{
    private List<Product> _products = [];
    public ProductsController(IWebHostEnvironment environment)
    {
        var wwwroot = environment.WebRootPath;
        var path = string.Concat(wwwroot, "/Data/products.json");

        GetProducts(path);
    }
    public ActionResult Index()
    {
        return View(_products);
    }

    private void GetProducts(string path)
    {
        _products = Storage.ReadProductsJson(path);
    }
}

