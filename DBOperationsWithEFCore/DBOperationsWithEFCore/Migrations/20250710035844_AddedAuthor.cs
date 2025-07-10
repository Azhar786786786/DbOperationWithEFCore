using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DBOperationsWithEFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddedAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Kuwaiti Dinar");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Saudi Riyal");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Thailand Currency", "Baht" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 7, "Japan Currency", "Yen" },
                    { 8, "Russian Rouble", "RUB" },
                    { 9, "Chinese Yuan Renminbi", "Yuan" }
                });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Urdu", "Urdu" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Arabic", "Arabic" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tamil", "Tamil" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Punjabi", "Punjabi" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Telugu", "Telugi" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 7, "English", "English" },
                    { 8, "Bhojpuri", "Bhojpuri" },
                    { 9, "Marathi", "Marathi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookPrices_BookId",
                table: "BookPrices",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookPrices_CurrencyId",
                table: "BookPrices",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrices_Books_BookId",
                table: "BookPrices",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrices_Currencies_CurrencyId",
                table: "BookPrices",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPrices_Books_BookId",
                table: "BookPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_BookPrices_Currencies_CurrencyId",
                table: "BookPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_BookPrices_BookId",
                table: "BookPrices");

            migrationBuilder.DropIndex(
                name: "IX_BookPrices_CurrencyId",
                table: "BookPrices");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Dinar");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Riyal");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Bott", "Bott" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tamil", "Tamil" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Punjabi", "Punjabi" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Urdu", "Urdu" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "English", "English" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Bhojpuri", "Bhojpuri" });
        }
    }
}
