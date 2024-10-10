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

    public ActionResult Details(int id)
    {
        // var found = _salesOrders.Where(o => o.OrderId == id).SingleOrDefault();
        var found = _salesOrders.SingleOrDefault(o => o.OrderId == id);
        return View(found);
    }

    private void GetOrders(string path)
    {
        _salesOrders = Storage.ReadJson(path);
    }
}

