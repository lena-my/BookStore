using BookStore.Data;
using BookStore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repositories;

public class AuthorRepository
{
    private readonly BookStoreDbContext _context;

    public AuthorRepository(BookStoreDbContext context)
    {
        _context = context;
    }

    public async Task<Author?> GetCategoryAsync(int authorId)
    {
        // Fetch the author by its Id
        Author? author = await _context.Authors
            .FirstOrDefaultAsync(a => a.Id == authorId); // Execute the query asynchronously
    
        return author;
    }
}