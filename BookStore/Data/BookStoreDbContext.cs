using BookStore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data;

public class BookStoreDbContext : DbContext
{
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
        : base(options)
    {
    }
    
    // Add tables to the database
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    // Seed initial data to database
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed initial data for Authors
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                Id = 1,
                Name = "George Orwell",
                Biography = "George Orwell was an English novelist, essayist, journalist, and critic. His work is characterized by clarity, intelligence, and wit, and often focuses on themes of social injustice, totalitarianism, and the misuse of power."
            },
            new Author
            {
                Id = 2,
                Name = "Harper Lee",
                Biography = "Harper Lee was an American novelist best known for her 1960 novel 'To Kill a Mockingbird', which was awarded the Pulitzer Prize for Fiction in 1961. The novel deals with serious issues such as racial inequality and moral growth."
            },
            new Author
            {
                Id = 3,
                Name = "J.K. Rowling",
                Biography = "J.K. Rowling is a British author, best known for the 'Harry Potter' series. Her books have gained worldwide recognition and have been adapted into a successful film series."
            },
            new Author
            {
                Id = 4,
                Name = "J.R.R. Tolkien",
                Biography = "J.R.R. Tolkien was an English writer, poet, and philologist, best known for his high-fantasy works 'The Hobbit' and 'The Lord of the Rings'. His work has had a profound impact on the fantasy genre."
            },
            new Author
            {
                Id = 5,
                Name = "F. Scott Fitzgerald",
                Biography = "F. Scott Fitzgerald was an American novelist and short story writer, widely regarded as one of the greatest American writers of the 20th century. He is best known for his novel 'The Great Gatsby'."
            }
        );

        // Seed initial data for Categories
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Fiction" },
            new Category { Id = 2, Name = "Science Fiction" },
            new Category { Id = 3, Name = "Fantasy" },
            new Category { Id = 4, Name = "Classics" }
        );

        // Seed initial data for Books
        modelBuilder.Entity<Book>().HasData(
            new Book
            {
                Id = 1,
                Title = "1984",
                AuthorId = 1, // George Orwell
                CategoryId = 2, // Science Fiction
                Price = 19.99,
                Description = "A dystopian social science fiction novel and cautionary tale.",
                CoverImage = "https://res.cloudinary.com/duvzo2rga/image/upload/c_thumb,w_200,g_face/v1724920059/1984_cjajde.jpg",
                ISBN = "978-0451524935"
            },
            new Book
            {
                Id = 2,
                Title = "To Kill a Mockingbird",
                AuthorId = 2, // Harper Lee
                CategoryId = 1, // Fiction
                Price = 14.99,
                Description = "A novel about the serious issues of rape and racial inequality.",
                CoverImage = "https://res.cloudinary.com/duvzo2rga/image/upload/c_thumb,w_200,g_face/v1724918903/to_kill_a_mockingbird_bpukqf.jpg",
                ISBN = "978-0061120084"
            },
            new Book
            {
                Id = 3,
                Title = "Harry Potter and the Sorcerer's Stone",
                AuthorId = 3, // J.K. Rowling
                CategoryId = 3, // Fantasy
                Price = 24.99,
                Description = "The first book in the Harry Potter series.",
                CoverImage = "https://res.cloudinary.com/duvzo2rga/image/upload/c_thumb,w_200,g_face/v1724919817/harryPotterAndTheSorcerStone_crccd4.jpg",
                ISBN = "978-0590353427"
            },
            new Book
            {
                Id = 4,
                Title = "The Hobbit",
                AuthorId = 4, // J.R.R. Tolkien
                CategoryId = 3, // Fantasy
                Price = 17.99,
                Description = "A fantasy novel and prelude to The Lord of the Rings.",
                CoverImage = "https://res.cloudinary.com/duvzo2rga/image/upload/c_thumb,w_200,g_face/v1724919898/theHobbit_lp2coq.jpg",
                ISBN = "978-0547928227"
            },
            new Book
            {
                Id = 5,
                Title = "The Great Gatsby",
                AuthorId = 5, // F. Scott Fitzgerald
                CategoryId = 4, // Classics
                Price = 15.99,
                Description = "A novel about the American dream and the Roaring Twenties.",
                CoverImage = "https://res.cloudinary.com/duvzo2rga/image/upload/c_thumb,w_200,g_face/v1724919986/theGreatGastby_wv8ftk.webp",
                ISBN = "978-0743273565"
            }
        );
    }
}