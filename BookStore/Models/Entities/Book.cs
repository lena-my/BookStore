namespace BookStore.Models.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public Author? Author { get; set; } = null;
    public int AuthorId { get; set; }
    public Category? Category { get; set; } = null;
    public int CategoryId { get; set; }
    public double Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public string CoverImage { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
}