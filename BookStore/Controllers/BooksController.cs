using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers;

public class BooksController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}