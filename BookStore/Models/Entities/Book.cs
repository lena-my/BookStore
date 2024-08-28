namespace BookStore.Models.Entities;

public class Book
{
    /*• Définir un modèle Book avec les propriétés suivantes : Id, Title, Author, Category,
    Price, Description, CoverImage, et ISBN (google :International Standard Book
            Number). */
    
    public int Id { get; }
    public string Title { get; set; } = string.Empty;
    public Author Author { get; set; }
    public Category Category { get; set; }
    public double Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public string CoverImage { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
}