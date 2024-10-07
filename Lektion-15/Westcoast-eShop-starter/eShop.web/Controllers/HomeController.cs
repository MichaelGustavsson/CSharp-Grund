using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace eShop.web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
