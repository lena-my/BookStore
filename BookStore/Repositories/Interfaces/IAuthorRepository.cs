using BookStore.Models.Entities;

namespace BookStore.Repositories.Interfaces;

public interface IAuthorRepository
{
    Task<Author?> GetCategoryAsync(int authorId);
}