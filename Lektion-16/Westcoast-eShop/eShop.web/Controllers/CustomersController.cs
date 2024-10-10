using eShop.models;
using Microsoft.AspNetCore.Mvc;

namespace eShop.web.Controllers;
public class CustomersController : Controller
{

  private List<Customer> _customers = [];
  public CustomersController(IWebHostEnvironment environment)
  {
    var wwwroot = environment.WebRootPath;
    var path = string.Concat(wwwroot, "/Data/customers.json");

    GetCustomers(path);
  }

  public ActionResult Index()
  {
    return View(_customers);
  }

  private void GetCustomers(string path)
  {
    _customers = Storage.ReadCustomersJson(path);
  }
}