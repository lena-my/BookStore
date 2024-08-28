using BookStore.Models.Entities;

namespace BookStore.Repositories.Interfaces;

public interface IBookRepository
{
    Task<List<Book>> GetBooksAsync();
}