using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf.Migrations
{
    public partial class Seededdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d55d38d-031e-416f-ab5e-edb0091e9a8f", "AQAAAAEAACcQAAAAEKDewpozFL+nzqtebXiE4LHsjcWYSKfvu5S5Jh6Faeg97Y8B6BJo+5Ovdvw1iyCP3Q==" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "ApplicationUserId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "00000000-ffff-ffff-ffff-ffffffffffff", "Jimmy John", 0 },
                    { 2, "00000000-ffff-ffff-ffff-ffffffffffff", "Jersy Mike", 0 },
                    { 3, "00000000-ffff-ffff-ffff-ffffffffffff", "Jared Fogul", 0 }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "Rating", "Title", "UserId", "YearPublished" },
                values: new object[] { 1, "00000000-ffff-ffff-ffff-ffffffffffff", 1, "Drama", 5, "Jimmy John", 0, 1990 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "Rating", "Title", "UserId", "YearPublished" },
                values: new object[] { 2, "00000000-ffff-ffff-ffff-ffffffffffff", 2, "Comedy", 5, "Jimmy John", 0, 1990 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "Rating", "Title", "UserId", "YearPublished" },
                values: new object[] { 3, "00000000-ffff-ffff-ffff-ffffffffffff", 3, "scary", 5, "Jimmy John", 0, 1990 });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text", "UserId" },
                values: new object[] { 1, "00000000-ffff-ffff-ffff-ffffffffffff", 1, "Jimmy Comment", 0 });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text", "UserId" },
                values: new object[] { 2, "00000000-ffff-ffff-ffff-ffffffffffff", 2, "Jersey Comment", 0 });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text", "UserId" },
                values: new object[] { 3, "00000000-ffff-ffff-ffff-ffffffffffff", 3, "Michael Comment", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe507f3d-e347-4881-be32-452d70a654fe", "AQAAAAEAACcQAAAAEBLO6Ky/Wg4xruPAG7gQjr0ZIQL730kB4166ZguylsLflIQ+tMuw9ye0gsRriI2AiQ==" });
        }
    }
}
