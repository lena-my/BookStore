using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "Name" },
                values: new object[,]
                {
                    { 1, "George Orwell was an English novelist, essayist, journalist, and critic. His work is characterized by clarity, intelligence, and wit, and often focuses on themes of social injustice, totalitarianism, and the misuse of power.", "George Orwell" },
                    { 2, "Harper Lee was an American novelist best known for her 1960 novel 'To Kill a Mockingbird', which was awarded the Pulitzer Prize for Fiction in 1961. The novel deals with serious issues such as racial inequality and moral growth.", "Harper Lee" },
                    { 3, "J.K. Rowling is a British author, best known for the 'Harry Potter' series. Her books have gained worldwide recognition and have been adapted into a successful film series.", "J.K. Rowling" },
                    { 4, "J.R.R. Tolkien was an English writer, poet, and philologist, best known for his high-fantasy works 'The Hobbit' and 'The Lord of the Rings'. His work has had a profound impact on the fantasy genre.", "J.R.R. Tolkien" },
                    { 5, "F. Scott Fitzgerald was an American novelist and short story writer, widely regarded as one of the greatest American writers of the 20th century. He is best known for his novel 'The Great Gatsby'.", "F. Scott Fitzgerald" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fiction" },
                    { 2, "Science Fiction" },
                    { 3, "Fantasy" },
                    { 4, "Classics" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CoverImage", "Description", "ISBN", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, 2, "https://example.com/covers/1984.jpg", "A dystopian social science fiction novel and cautionary tale.", "978-0451524935", 19.989999999999998, "1984" },
                    { 2, 2, 1, "https://example.com/covers/mockingbird.jpg", "A novel about the serious issues of rape and racial inequality.", "978-0061120084", 14.99, "To Kill a Mockingbird" },
                    { 3, 3, 3, "https://example.com/covers/harrypotter1.jpg", "The first book in the Harry Potter series.", "978-0590353427", 24.989999999999998, "Harry Potter and the Sorcerer's Stone" },
                    { 4, 4, 3, "https://example.com/covers/hobbit.jpg", "A fantasy novel and prelude to The Lord of the Rings.", "978-0547928227", 17.989999999999998, "The Hobbit" },
                    { 5, 5, 4, "https://example.com/covers/gatsby.jpg", "A novel about the American dream and the Roaring Twenties.", "978-0743273565", 15.99, "The Great Gatsby" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
