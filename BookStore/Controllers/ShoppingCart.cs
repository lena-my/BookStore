using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers;

public class ShoppingCart : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}