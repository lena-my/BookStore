using BookStore.Data;
using BookStore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repositories;

public class CategoryRepository
{
    private readonly BookStoreDbContext _context;

    public CategoryRepository(BookStoreDbContext context)
    {
        _context = context;
    }

    public async Task<Category?> GetCategoryAsync(int categoryId)
    {
        // Fetch the category by its Id
        Category? category = await _context.Categories
            .FirstOrDefaultAsync(c => c.Id == categoryId); // Execute the query asynchronously
    
        return category;
    }
}