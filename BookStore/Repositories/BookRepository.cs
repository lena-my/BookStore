using BookStore.Data;
using BookStore.Models.Entities;
using BookStore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repositories;

public class BookRepository : IBookRepository
{
    private readonly BookStoreDbContext _context;

    public BookRepository(BookStoreDbContext context)
    {
        _context = context;
    }

    public async Task<List<Book>> GetBooksAsync()
    {
        // Fetch the list of books from the database
        var books = await _context.Books
            .Include(b => b.Author)  // Include related Author data
            .Include(b => b.Category) // Include related Category data
            .ToListAsync(); // Execute the query asynchronously
        return books;
    }
}