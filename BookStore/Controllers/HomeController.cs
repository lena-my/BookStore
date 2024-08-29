using System.Diagnostics;
using BookStore.Data;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using BookStore.Models.Entities;
using BookStore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IBookRepository _bookRepository;

    public HomeController(ILogger<HomeController> logger, IBookRepository bookRepository)
    {
        _logger = logger;
        _bookRepository = bookRepository;
    }

    // GET
    public async Task<IActionResult> Index()
    {
        // Fetch the list of books from the database
        var books = await _bookRepository.GetBooksAsync();
        
        return View(books);
    }

    [HttpGet("search")]
    public async Task<IActionResult> Search(string searchBy, string query)
    {
        // Validate input
        if (string.IsNullOrWhiteSpace(query))
        {
            return Json(new List<object>()); // Return an empty list if query is empty
        }

        // Retrieve books
        var books = await _bookRepository.GetBooksAsync(); // Assuming this returns List<Book>

        // Apply filters based on the search criteria
        var filteredBooks = books.AsQueryable(); // Convert List<Book> to IQueryable<Book>

        switch (searchBy.ToLower())
        {
            case "title":
                filteredBooks = filteredBooks.Where(b => b.Title.Contains(query, StringComparison.OrdinalIgnoreCase));
                break;
            case "author":
                filteredBooks = filteredBooks.Where(b => b.Author.Name.Contains(query, StringComparison.OrdinalIgnoreCase));
                break;
            case "category":
                filteredBooks = filteredBooks.Where(b => b.Category.Name.Contains(query, StringComparison.OrdinalIgnoreCase));
                break;
            default:
                return BadRequest("Invalid search criteria.");
        }

        // Project the query results into a simple type
        var result = filteredBooks
            .Select(b => new 
            {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author.Name,
                Price = b.Price.ToString("C")
            })
            .ToList(); // No need for ToListAsync here since books is already in memory

        // Return the results as JSON
        return Json(result);
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