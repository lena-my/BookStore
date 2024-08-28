using BookStore.Models.Entities;

namespace BookStore.Repositories.Interfaces;

public interface ICategoryInterface
{
    Task<Category?> GetCategoryAsync(int categoryId);
}