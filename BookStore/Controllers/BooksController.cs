using BookStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers;

public class BooksController : Controller
{
    private readonly BookStoreDbContext _context;

    public BooksController(BookStoreDbContext context)
    {
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
}