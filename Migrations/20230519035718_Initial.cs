using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microblog.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    BlogPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.BlogPostId);
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "Category", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 1, "Personal", "lectus sit amet est placerat in egestas erat imperdiet sed euismod nisi porta lorem mollis aliquam ut porttitor leo a diam sollicitudin tempor id eu.", new DateTime(2023, 5, 18, 20, 57, 18, 75, DateTimeKind.Local).AddTicks(6725), "Chilaquiles verdes please", new DateTime(2023, 5, 18, 20, 57, 18, 75, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "Category", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 2, "Development", "lectus sit amet est placerat in egestas erat imperdiet sed euismod nisi porta lorem mollis aliquam ut porttitor leo a diam sollicitudin tempor id eu.", new DateTime(2023, 5, 18, 20, 57, 18, 75, DateTimeKind.Local).AddTicks(6737), "Aspiring polymath", new DateTime(2023, 5, 18, 20, 57, 18, 75, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "Category", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 3, "Travel", "lectus sit amet est placerat in egestas erat imperdiet sed euismod nisi porta lorem mollis aliquam ut porttitor leo a diam sollicitudin tempor id eu.", new DateTime(2023, 5, 18, 20, 57, 18, 75, DateTimeKind.Local).AddTicks(6739), "Mexico born, Texas raised", new DateTime(2023, 5, 18, 20, 57, 18, 75, DateTimeKind.Local).AddTicks(6740) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");
        }
    }
}
