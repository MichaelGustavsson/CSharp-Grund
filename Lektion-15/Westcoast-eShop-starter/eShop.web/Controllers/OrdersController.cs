using eShop.models;
using Microsoft.AspNetCore.Mvc;

namespace eShop.web.Controllers;

public class OrdersController : Controller
{
    private List<SalesOrder> _salesOrders = [];
    private readonly IWebHostEnvironment _environment;

    // Depency Injection...
    public OrdersController(IWebHostEnvironment environment)
    {
        _environment = environment;
        var root = _environment.WebRootPath;
        var path = string.Concat(root, "/Data/orders.json");
        GetOrders(path);
    }
    public ActionResult Index()
    {
        return View(_salesOrders);
    }

    private void GetOrders(string path)
    {
        _salesOrders = Storage.ReadJson(path);
    }
}

