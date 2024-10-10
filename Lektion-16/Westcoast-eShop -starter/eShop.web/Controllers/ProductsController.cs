using Microsoft.AspNetCore.Mvc;

namespace eShop.web.Controllers;

public class ProductsController : Controller
{
    // GET: ProductsController
    public ActionResult Index()
    {
        return View();
    }

}

