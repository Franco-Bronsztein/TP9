using Microsoft.AspNetCore.Mvc;

namespace TP9.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }


}
