using BookStore.Data;
using BookStore.Models.Entities;
using BookStore.Repositories;
using BookStore.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers;

public class BooksController : Controller
{
    private readonly IBookRepository _bookRepository;


    public BooksController(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    // GET
    public async Task<IActionResult> GetBook(int Id)
    {
        Book? book = await _bookRepository.GetBookAsync(Id);
        return View(book);
    }
}