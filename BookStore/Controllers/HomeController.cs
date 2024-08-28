using System.Diagnostics;
using BookStore.Data;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly BookStoreDbContext _context;

    public HomeController(ILogger<HomeController> logger, BookStoreDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    // GET
    public async Task<IActionResult> Index()
    {
        // Fetch the list of books from the database
        var books = await _context.Books
            .Include(b => b.Author)  // Include related Author data
            .Include(b => b.Category) // Include related Category data
            .ToListAsync(); // Execute the query asynchronously

        // Pass the list of books to the view
        return View(books);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}