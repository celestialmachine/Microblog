using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microblog.Migrations
{
    public partial class TestContentUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { "Set up folder structure. Deleted starter files. Added own HomeController. Added BlogPost class. Added own /Home/Index.chtml. Added own _layout. Added Tagg Helper to _ViewImports", new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9605), "Microblog, day one", new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { "Added EF Core. Added DBContext class(MicroblogContext) with starter seed data. Added EF Core dependency injection. Added bootstrap and supporting jQuery, popper. Added bootstrap and supporting scripts to _Layout. Added connection string. Created database using migrations. Added mbcontext to home controller to test mvc pattern. Quick render of data on home/index. Misspelled TagHelpers on _ViewImports and cried for an hour.", new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9621), "Microblog, day two", new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: 3,
                columns: new[] { "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { "Tried to do an initial style of blog with bootstrap but not sure the results are the best. For something so simple I might just do my own styling.", new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9622), "Microblog, day three", new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9623) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { "lectus sit amet est placerat in egestas erat imperdiet sed euismod nisi porta lorem mollis aliquam ut porttitor leo a diam sollicitudin tempor id eu.", new DateTime(2023, 5, 18, 20, 57, 18, 75, DateTimeKind.Local).AddTicks(6725), "Chilaquiles verdes please", new DateTime(2023, 5, 18, 20, 57, 18, 75, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { "lectus sit amet est placerat in egestas erat imperdiet sed euismod nisi porta lorem mollis aliquam ut porttitor leo a diam sollicitudin tempor id eu.", new DateTime(2023, 5, 18, 20, 57, 18, 75, DateTimeKind.Local).AddTicks(6737), "Aspiring polymath", new DateTime(2023, 5, 18, 20, 57, 18, 75, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: 3,
                columns: new[] { "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { "lectus sit amet est placerat in egestas erat imperdiet sed euismod nisi porta lorem mollis aliquam ut porttitor leo a diam sollicitudin tempor id eu.", new DateTime(2023, 5, 18, 20, 57, 18, 75, DateTimeKind.Local).AddTicks(6739), "Mexico born, Texas raised", new DateTime(2023, 5, 18, 20, 57, 18, 75, DateTimeKind.Local).AddTicks(6740) });
        }
    }
}
