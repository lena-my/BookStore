﻿// <auto-generated />
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    partial class BookStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStore.Models.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biography = "George Orwell was an English novelist, essayist, journalist, and critic. His work is characterized by clarity, intelligence, and wit, and often focuses on themes of social injustice, totalitarianism, and the misuse of power.",
                            Name = "George Orwell"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "Harper Lee was an American novelist best known for her 1960 novel 'To Kill a Mockingbird', which was awarded the Pulitzer Prize for Fiction in 1961. The novel deals with serious issues such as racial inequality and moral growth.",
                            Name = "Harper Lee"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "J.K. Rowling is a British author, best known for the 'Harry Potter' series. Her books have gained worldwide recognition and have been adapted into a successful film series.",
                            Name = "J.K. Rowling"
                        },
                        new
                        {
                            Id = 4,
                            Biography = "J.R.R. Tolkien was an English writer, poet, and philologist, best known for his high-fantasy works 'The Hobbit' and 'The Lord of the Rings'. His work has had a profound impact on the fantasy genre.",
                            Name = "J.R.R. Tolkien"
                        },
                        new
                        {
                            Id = 5,
                            Biography = "F. Scott Fitzgerald was an American novelist and short story writer, widely regarded as one of the greatest American writers of the 20th century. He is best known for his novel 'The Great Gatsby'.",
                            Name = "F. Scott Fitzgerald"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CoverImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CategoryId = 2,
                            CoverImage = "https://res.cloudinary.com/duvzo2rga/image/upload/c_thumb,w_200,g_face/v1724920059/1984_cjajde.jpg",
                            Description = "A dystopian social science fiction novel and cautionary tale.",
                            ISBN = "978-0451524935",
                            Price = 19.989999999999998,
                            Title = "1984"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            CategoryId = 1,
                            CoverImage = "https://res.cloudinary.com/duvzo2rga/image/upload/c_thumb,w_200,g_face/v1724918903/to_kill_a_mockingbird_bpukqf.jpg",
                            Description = "A novel about the serious issues of rape and racial inequality.",
                            ISBN = "978-0061120084",
                            Price = 14.99,
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            CategoryId = 3,
                            CoverImage = "https://res.cloudinary.com/duvzo2rga/image/upload/c_thumb,w_200,g_face/v1724919817/harryPotterAndTheSorcerStone_crccd4.jpg",
                            Description = "The first book in the Harry Potter series.",
                            ISBN = "978-0590353427",
                            Price = 24.989999999999998,
                            Title = "Harry Potter and the Sorcerer's Stone"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            CategoryId = 3,
                            CoverImage = "https://res.cloudinary.com/duvzo2rga/image/upload/c_thumb,w_200,g_face/v1724919898/theHobbit_lp2coq.jpg",
                            Description = "A fantasy novel and prelude to The Lord of the Rings.",
                            ISBN = "978-0547928227",
                            Price = 17.989999999999998,
                            Title = "The Hobbit"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 5,
                            CategoryId = 4,
                            CoverImage = "https://res.cloudinary.com/duvzo2rga/image/upload/c_thumb,w_200,g_face/v1724919986/theGreatGastby_wv8ftk.webp",
                            Description = "A novel about the American dream and the Roaring Twenties.",
                            ISBN = "978-0743273565",
                            Price = 15.99,
                            Title = "The Great Gatsby"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fiction"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Classics"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Entities.Book", b =>
                {
                    b.HasOne("BookStore.Models.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Models.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
