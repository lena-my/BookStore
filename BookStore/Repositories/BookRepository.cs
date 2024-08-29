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

    public async Task<Book?> GetBookAsync(int bookId)
    {
        // Fetch the book by its Id, including related entities like Author and Category
        Book? book = await _context.Books
            .Include(b => b.Author) // Include related Author
            .Include(b => b.Category) // Include related Category
            .FirstOrDefaultAsync(b => b.Id == bookId); // Execute the query asynchronously
    
        if (book != null)
        {
            
            var author = await _context.Authors.FirstOrDefaultAsync(a => a.Id == book.AuthorId);
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == book.CategoryId);

            // You could then attach these to the book if needed
            book.Author = author;
            book.Category = category;
        }
        
        return book;
    }

    public async Task<Book> FindBooksByAuthor(Author author)
    {
        List<Book> books = new List<Book>();
        //TODO
        return null;
    }
}