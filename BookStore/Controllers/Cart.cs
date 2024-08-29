using BookStore.Models;
using BookStore.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers;

public class Cart : Controller
{
    // GET
    public async Task<IActionResult> AddToCart(int productId, int quantity)
    {
        var cart = HttpContext.Session.GetObject<List<CartItem>>("Cart") ?? new List<CartItem>();
        var cartItem = cart.FirstOrDefault(item => item.ProductId == productId);
        if (cartItem != null)
        {
            cartItem.Quantity += quantity;
        }
        else
        {
            cart.Add(new CartItem { ProductId = productId, Quantity = quantity });
        }
        HttpContext.Session.SetObject("Cart", cart);

        return RedirectToAction("Index");
    }
    
    // GET
    public async Task<IActionResult> ViewCart()
    {
        return View();
    }
    
    // GET
    public async Task<IActionResult> RemoveFromCart()
    {
        return View();
    }
}